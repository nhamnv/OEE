using Common;
using Common.ViewModels;
using Service.IService;

namespace Service.Service
{
    public class ReportMachineRuningStatusService : IReportMachineRuningStatusService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="MachineGroupID"></param>
        /// <param name="MachineLocationID"></param>
        /// <param name="MachineID">Tham số này chỉ dùng cho màn hình chi tiết (Xem chi tiết 1 máy)</param>
        /// <returns></returns>
        public List<MachineRuningStatusViewModel> GetReportMachineRuningStatus(DateTime StartDate, DateTime EndDate, string MachineGroupID, string MachineLocationID, string MachineID = "")
        {
            List<MachineRuningStatusViewModel> reval = new List<MachineRuningStatusViewModel>();
            try
            {
                // Lịch sử trạng thái của tất cả các máy, các vị trí trong khoảng thời gian xác định
                var hisData = (from h in StaticData.Data_MachineStatusHistory
                               where (h.StatusTime >= StartDate && h.StatusTime <= EndDate)
                               join m in StaticData.Data_Machine on h.MachineID equals m.MachineID
                               join ls in StaticData.Data_MachineLocationSetup on h.MachineID equals ls.MachineID
                               join l in StaticData.Data_MachineLocation on ls.LocationID equals l.LocationID
                               join s in StaticData.Data_MachineStatus on h.StatusID equals s.StatusID
                               orderby h.StatusTime
                               select new
                               {

                                   //h.MachineStatusHistoryID
                                   // ,
                                   h.MachineID
                                    ,
                                   h.StatusID
                                    ,
                                   h.StatusTime
                                    ,
                                   s.StatusName
                                    ,
                                   s.ColorCode
                                    ,
                                   m.MachineGroupID
                                    ,
                                   m.MachineGroupName
                                    ,
                                   m.MachineModel
                                    ,
                                   m.MachineAvatar
                                    ,
                                   m.MachineName
                                    ,
                                   l.LocationID
                                    ,
                                   l.LocationName
                               }).Distinct();

                #region Filter
                if (!string.IsNullOrEmpty(MachineID) && MachineID.ToLower() != "all")
                {
                    hisData = from h in hisData
                              where h.MachineID.ToString() == MachineID
                              select h;
                }

                if (!string.IsNullOrEmpty(MachineGroupID) && MachineGroupID.ToLower() != "all")
                {
                    hisData = from h in hisData
                              where h.MachineGroupID.ToString() == MachineGroupID
                              select h;
                }

                if (!string.IsNullOrEmpty(MachineLocationID) && MachineLocationID.ToLower() != "all")
                {
                    hisData = from h in hisData
                              where h.LocationID.ToString() == MachineLocationID
                              select h;
                }

                #endregion

                #region asign data


                var listMachine = hisData
                    .DistinctBy(d => new
                    {
                        d.MachineID
                                   ,
                        d.MachineGroupID
                                   ,
                        d.MachineGroupName
                                   ,
                        d.MachineName
                                   ,
                        d.MachineModel
                                   ,
                        d.MachineAvatar
                                    ,
                        d.LocationID
                                   ,
                        d.LocationName

                    }).ToList();


                foreach (var item in listMachine)
                {
                    #region Populate timeline by status

                    List<TimelineSeriesData> timeline = new List<TimelineSeriesData>();

                    var tempHisData = hisData?.Where(m => m.MachineID == item.MachineID && m.LocationID == item.LocationID)?.OrderBy(o => o.StatusTime);

                    if (tempHisData != null)
                    {
                        foreach (var h in tempHisData)
                        {
                            var sd = new TimelineSeriesData()
                            {
                                x = h.StatusName,
                                fillColor = h.ColorCode,
                                _StatusID = h.StatusID,
                            };

                            #region Mốc start: Time của bản ghi hiện tại
                            sd.y.Add((long)(h.StatusTime - new DateTime(1970, 1, 1)).TotalMilliseconds);
                            #endregion

                            #region Mốc end: Time của bản ghi kế tiếp để làm mốc kết thúc cho status hiện tại

                            var t2 = (from dt in tempHisData
                                      orderby dt.StatusTime ascending
                                      where dt.StatusTime > h.StatusTime
                                      select new { StatusTime = (DateTime)dt.StatusTime })?.FirstOrDefault()?.StatusTime;

                            // Nếu không tìm thấy mốc thứ 2 hoặc tìm thấy nhưng nằm ngoài khoảng date đã chọn thì set = mốc cuối của date đã chọn
                            if (t2 is null || t2 > EndDate)
                                t2 = EndDate;
                            sd.y.Add((long)(t2.Value - new DateTime(1970, 1, 1)).TotalMilliseconds);

                            #endregion

                            //var a = (from dt in hisData
                            //         orderby dt.StatusTime ascending
                            //         where dt.StatusTime > h.StatusTime
                            //         select new { StatusTime = (DateTime)dt.StatusTime }).FirstOrDefault().StatusTime
                            //        ;

                            timeline.Add(sd);
                        }
                    }
                    #endregion

                    #region Tính % các trạng thái (đơn vị cơ sở tính = mili giây)
                    double baseTimeRange_milisecond = (EndDate - StartDate).TotalMilliseconds;
                    long realTotalmiliSeconds = 0;

                    List<Common.Data_MachineStatus> listStatusPercent = new List<Data_MachineStatus>();
                    foreach (var s in StaticData.Data_MachineStatus)
                    {
                        realTotalmiliSeconds = 0;
                        var sPcent = new Data_MachineStatus() { ColorCode = s.ColorCode, StatusID = s.StatusID, StatusName = s.StatusName };

                        try
                        {
                            var allSt = timeline?.Where(t => t._StatusID == s.StatusID);
                            if (allSt != null && allSt.Any())
                            {
                                foreach (var tempSt in allSt)
                                {
                                    realTotalmiliSeconds += (tempSt.y[1] - tempSt.y[0]);
                                }
                            }

                            sPcent.DataPercent = (long)(realTotalmiliSeconds * 100 / baseTimeRange_milisecond);

                        }
                        catch (Exception ex)
                        {

                        }

                        listStatusPercent.Add(sPcent);
                    }


                    #endregion

                    // Add machine
                    reval.Add(new MachineRuningStatusViewModel()
                    {
                        MachineID = item.MachineID,
                        MachineName = item.MachineName,
                        MachineModel = item.MachineModel,
                        MachineAvatar = item.MachineAvatar ?? "no_image.png", // OEE\WDI.OEE\wwwroot\images\products\no_image.png
                        MachineLocationName = item.LocationName,
                        MachineLocationID = item.LocationID,
                        ListStatusPercent = listStatusPercent,
                        StatusHistories = (from h in hisData
                                           where h.MachineID == item.MachineID
                                           select new Common.Data_MachineStatusHistory()
                                           {
                                               //MachineStatusHistoryID = h.MachineStatusHistoryID,
                                               MachineID = h.MachineID,
                                               StatusID = h.StatusID,
                                               StatusTime = h.StatusTime
                                           }).ToList()
                                           ,
                        SeriesTimeLine = timeline
                    });
                }


                #endregion

            }
            catch (Exception ex)
            {

            }

            return reval;
        }
    }
}
