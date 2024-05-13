using Common;
using Common.ViewModels;
using Service.IService;

namespace Service.Service
{
    public class DashboardService : IDashboardService
    {
        public DashboardViewModel GetData(DateTime reportDate)
        {
            // Nếu không chỉ định thời gian thì lấy thời điểm hiện tại
            if (reportDate == null) { reportDate = DateTime.Now; }



            DashboardViewModel reval = new DashboardViewModel();

            try
            {
                // Random rand = new Random();

                #region Danh sach may kem trang thai cuoi cung den thoi diem hien tai

                var lstMachineLastStatus =
                    (from m in StaticData.Data_Machine
                     join s in StaticData.Data_MachineLocationSetup on m.MachineID equals s.MachineID
                     join l in StaticData.Data_MachineLocation on s.LocationID equals l.LocationID
                     join h in StaticData.Data_MachineStatusHistory on m.MachineID equals h.MachineID into x

                     select new MachineStatus
                     {
                         MachineGroupID = m.MachineGroupID,
                         MachineGroupName = m.MachineGroupName,
                         MachineID = m.MachineID,
                         MachineName = m.MachineName,
                         MachineLocationID = l.LocationID,
                         MachineLocationName = l.LocationName,

                         MachineStatusID = x.Where(t => t.StatusTime <= reportDate).OrderByDescending(o => o.StatusTime).FirstOrDefault()?.StatusID ?? 0
                         ,
                         MachineStatusName = (from st in StaticData.Data_MachineStatus
                                              where st.StatusID == (x.Where(t => t.StatusTime <= reportDate).OrderByDescending(o => o.StatusTime).FirstOrDefault()?.StatusID)
                                              select new { st }
                                              ).ToList().FirstOrDefault()?.st.StatusName ?? ""

                     }
                    ).ToList().Where(t => t.MachineStatusID > 0);

                #endregion


                #region Lấy 6 trạng thái cùng với số liệu theo nhóm máy

                foreach (var s in StaticData.Data_MachineStatus)
                {
                    var sts = new DashboardStatusSummary()
                    {
                        ColorCode = s.ColorCode,
                        StatusName = s.StatusName,
                    };


                    var machinesByStatus = lstMachineLastStatus.Where(t => t.MachineStatusID == s.StatusID);


                    // Count số máy có trạng thái này
                    sts.MachineCount = machinesByStatus?.Count() ?? 0;

                    // Count số máy có trạng thái này theo group
                    //var grp = machinesByStatus?
                    //    .GroupBy(d => new { d.MachineGroupID, d.MachineGroupName })
                    //    .Select(d => new { d.Key })
                    //    .ToList();


                    foreach (var g in StaticData.Data_MachineGroup)
                    {
                        sts.MachineGroups.Add(new MachineGroup()
                        {
                            GroupName = g.MachineGroupName
                            ,
                            MachineCount = (machinesByStatus?
                                            .Where(t => t.MachineGroupID == g.MachineGroupID)
                                            .Distinct()
                                            .ToList())?.Count ?? 0

                        });
                    }

                    reval.LitStatusSummary.Add(sts);
                }

                #endregion

                #region Lấy danh sách trạng thái các máy

                reval.ListMachineStatus = lstMachineLastStatus?.ToList() ?? new List<MachineStatus>();

                #endregion
            }
            catch (Exception ex)
            {

            }

            return reval;
        }
    }
}

