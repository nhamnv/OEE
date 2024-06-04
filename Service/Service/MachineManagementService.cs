using Common;
using Common.ViewModels;
using Service.IService;

namespace Service.Service
{
    public class MachineManagementService : IMachineManagementService
    {


        public MachineStatiticsViewModel GetStatitics()
        {
            MachineStatiticsViewModel reval = new MachineStatiticsViewModel();

            #region Fake data

            // Box - Số nhà xưởng
            reval.BoxTotalWorkshop = new BoxData()
            {
                Title = "Số nhà xưởng",
                Value = 3,
                Data = new List<ChartItemViewModel>()
            };

            // Box - Tổng số máy
            reval.BoxTotalMachine = new BoxData()
            {
                Title = "Tổng số máy",
                Value = 43,
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="AH1", Value=10, ColorCode="#FFFFFF",DataID=1},
                    new ChartItemViewModel() {Name="AH2", Value=28, ColorCode="#FFFFFF",DataID=2},
                    new ChartItemViewModel() {Name="AH3", Value=5, ColorCode="#FFFFFF",DataID=3}
                }
            };

            // Box - Số máy theo nhóm
            reval.BoxTotalMachineByGroup = new BoxData()
            {
                Title = "Số máy theo nhóm",
                Value = 43,
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="GCN", Value=10, ColorCode="#FFFFFF",DataID=1},
                    new ChartItemViewModel() {Name="DCTH", Value=25, ColorCode="#FFFFFF",DataID=2},
                    new ChartItemViewModel() {Name="LASER", Value=1, ColorCode="#FFFFFF",DataID=3},
                    new ChartItemViewModel() {Name="PLASMA", Value=5, ColorCode="#FFFFFF",DataID=4},
                    new ChartItemViewModel() {Name="ROBOT", Value=2, ColorCode="#FFFFFF",DataID=5},
                }
            };

            // Pie Chart - Tỷ lệ máy theo từng xưởng
            reval.PieChartRateOfTotalMachineByWorkshop = new ChartData()
            {
                Title = "Tỷ lệ máy theo từng xưởng",
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="AH1", Value=23.26, ColorCode="#E17084", DataID=1},
                    new ChartItemViewModel() {Name="AH2", Value=56.12, ColorCode="#6aa1e4", DataID=2},
                    new ChartItemViewModel() {Name="AH3", Value=11.63, ColorCode="#f1cf6d", DataID=3}
                }
            };

            // Pie Chart - Tỷ lệ máy theo nhóm máy
            reval.PieChartRateOfTotalMachineByGroup = new ChartData()
            {
                Title = "Tỷ lệ máy theo nhóm máy",
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="GCN", Value=23.26,      ColorCode="#E17084", DataID=1},
                    new ChartItemViewModel() {Name="DCTH", Value=58.14,     ColorCode="#6aa1e4", DataID=2},
                    new ChartItemViewModel() {Name="LASER", Value=2.33,     ColorCode="#f1cf6d", DataID=3},
                    new ChartItemViewModel() {Name="PLASMA", Value=11.63,   ColorCode="#73c84f", DataID=4},
                    new ChartItemViewModel() {Name="ROBOT", Value=4.65,     ColorCode="#df4d26", DataID=5},
                }
            };

            // Pie Chart - Tỷ lệ máy theo nhóm tài sản
            reval.PieChartRateOfTotalMachineByAssetGroup = new ChartData()
            {
                Title = "Tỷ lệ máy theo nhóm tài sản",
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="Máy cắt", Value=18.6, ColorCode="#e17084", DataID = 1},
                    new ChartItemViewModel() {Name="Máy cưa", Value=2.33, ColorCode="#6aa1e4", DataID = 2},
                    new ChartItemViewModel() {Name="Máy khoan", Value=4.65, ColorCode="#f1cf6d", DataID = 3},
                    new ChartItemViewModel() {Name="Máy phay", Value=6.98, ColorCode="#73c84f", DataID = 4},
                    new ChartItemViewModel() {Name="Máy lốc, uốn, gấp mép, xoay ống", Value=4.65, ColorCode="#df4d26", DataID = 5},
                    new ChartItemViewModel() {Name="Máy ráp dầm, H/I-Đính, Gá, Lật, VC dầm", Value=23.26, ColorCode="#6798f7", DataID = 6},
                    new ChartItemViewModel() {Name="Máy nắn thẳng", Value=4.65, ColorCode="#5c360f", DataID = 7},
                    new ChartItemViewModel() {Name="Máy hàn cổng", Value=34.88, ColorCode="#696796", DataID = 8}
                }
            };


            // Table - Thống kê theo nhóm máy và xưởng -- Cần làm lại số liệu nhé
            reval.BarChartListMachineByGroupAndWorkshop = new BarChart()
            {
                Title = "Thống kê theo nhóm máy và xưởng sản xuất",
                Data = new List<ChartData>()
                {
                    new ChartData()
                    {
                        Title="AH1",
                        ColorCode="#E17084",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=2,      ColorCode="#E17084", DataID=1},
                            new ChartItemViewModel() {Name="DCTH", Value=9,     ColorCode="#6aa1e4", DataID=1},
                            new ChartItemViewModel() {Name="LASER", Value=7,    ColorCode="#f1cf6d", DataID=1},
                            new ChartItemViewModel() {Name="PLASMA", Value=11,  ColorCode="#73c84f", DataID=1},
                            new ChartItemViewModel() {Name="ROBOT", Value=4,    ColorCode="#df4d26", DataID=1},
                        }
                    },
                    new ChartData()
                    {
                        Title="AH2",
                        ColorCode="#6aa1e4",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=14,     ColorCode="#E17084", DataID=2},
                            new ChartItemViewModel() {Name="DCTH", Value=3,     ColorCode="#6aa1e4", DataID=2},
                            new ChartItemViewModel() {Name="LASER", Value=4,    ColorCode="#f1cf6d", DataID=2},
                            new ChartItemViewModel() {Name="PLASMA", Value=9,   ColorCode="#73c84f", DataID=2},
                            new ChartItemViewModel() {Name="ROBOT", Value=12,   ColorCode="#df4d26", DataID=2},
                        }
                    },
                    new ChartData()
                    {
                        Title="AH3",
                        ColorCode="#f1cf6d",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=6,      ColorCode="#E17084", DataID=3},
                            new ChartItemViewModel() {Name="DCTH", Value=1,     ColorCode="#6aa1e4", DataID=3},
                            new ChartItemViewModel() {Name="LASER", Value=0,    ColorCode="#f1cf6d", DataID=3},
                            new ChartItemViewModel() {Name="PLASMA", Value=2,   ColorCode="#73c84f", DataID=3},
                            new ChartItemViewModel() {Name="ROBOT", Value=0,    ColorCode="#df4d26", DataID=3},
                        }
                    },
                }
            };

            // Table - Thống kê theo nhóm máy và xưởng 2  -- Cần làm lại số liệu nhé
            reval.BarChartListMachineByGroupAndWorkshop2 = new BarChart()
            {
                Title = "Thống kê theo nhóm máy và xưởng sản xuất",
                Data = new List<ChartData>()
                {
                    new ChartData()
                    {
                        Title="GCN",
                        ColorCode ="#E17084",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=14, ColorCode="#E17084", DataID=1},
                            new ChartItemViewModel() {Name="AH2", Value=17, ColorCode="#6aa1e4", DataID=1},
                            new ChartItemViewModel() {Name="AH3", Value=6,  ColorCode="#f1cf6d", DataID=1}
                        }
                    },
                    new ChartData()
                    {
                        Title="DCTH",
                        ColorCode ="#6aa1e4",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=3,  ColorCode="#E17084", DataID=2},
                            new ChartItemViewModel() {Name="AH2", Value=6,  ColorCode="#6aa1e4", DataID=2},
                            new ChartItemViewModel() {Name="AH3", Value=15, ColorCode="#f1cf6d", DataID=2}
                        }
                    },
                    new ChartData()
                    {
                        Title="LASER",
                        ColorCode ="#f1cf6d",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=12, ColorCode="#E17084", DataID=3},
                            new ChartItemViewModel() {Name="AH2", Value=4,  ColorCode="#6aa1e4", DataID=3},
                            new ChartItemViewModel() {Name="AH3", Value=18, ColorCode="#f1cf6d", DataID=3}
                        }
                    },
                    new ChartData()
                    {
                        Title="PLASMA",
                        ColorCode ="#73c84f",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=8,  ColorCode="#E17084", DataID=4},
                            new ChartItemViewModel() {Name="AH2", Value=16, ColorCode="#6aa1e4", DataID=4},
                            new ChartItemViewModel() {Name="AH3", Value=1,  ColorCode="#f1cf6d", DataID=4}
                        }
                    },
                    new ChartData()
                    {
                        Title="ROBOT",
                        ColorCode ="#df4d26",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=27, ColorCode="#E17084", DataID=5},
                            new ChartItemViewModel() {Name="AH2", Value=4,  ColorCode="#6aa1e4", DataID=5},
                            new ChartItemViewModel() {Name="AH3", Value=18, ColorCode="#f1cf6d", DataID=5}
                        }
                    },
                }
            };

            #endregion

            return reval;
        }

        public MachineDetailViewModel GetDetails(int machineID, int machineLocationID)
        {
            MachineDetailViewModel reval = new MachineDetailViewModel();

            try
            {
                reval.Machine = (from m in StaticData.Data_Machine
                                 where m.MachineID == machineID
                                 select new Common.Data_Machine()
                                 {
                                     MachineID = machineID,
                                     AccountantCode = m.AccountantCode,
                                     AssetGroupID = m.AssetGroupID,
                                     AssetGroupName = m.AssetGroupName,
                                     BaseUnitID = m.BaseUnitID,
                                     BaseUnitName = m.BaseUnitName,
                                     FirstUseDate = m.FirstUseDate,
                                     MachineAssetCode = m.MachineAssetCode,
                                     MachineGroupID = m.MachineGroupID,
                                     MachineGroupName = m.MachineGroupName,
                                     MachineLocationID = m.MachineLocationID,
                                     MachineLocationName = m.MachineLocationName,
                                     MachineName = m.MachineName,
                                     Model = m.Model,
                                     ProviderID = m.ProviderID,
                                     ProviderName = m.ProviderName,
                                     SerialNo = m.SerialNo,
                                     UmageUrl = m.UmageUrl,
                                     ListComponents = m.ListComponents,
                                 })?.FirstOrDefault() ?? new Data_Machine();
            }
            catch (Exception)
            {

            }
            return reval;
        }

        public List<Data_RepaireHistory> GetMachineRepaireHistory(int machineID)
        {
            List<Data_RepaireHistory> reval = new List<Data_RepaireHistory>();
            try
            {
                return StaticData.Data_RepaireHistory.Where(t => t.MachineID == machineID)?.OrderByDescending(o => o.DateFinishTask)?.ToList() ?? new List<Data_RepaireHistory>();
            }
            catch (Exception)
            {

            }
            return reval;
        }

        public List<Data_MachineMaintenanceList> GetMachineMaintenanceList(int machineID)
        {
            List<Data_MachineMaintenanceList> reval = new List<Data_MachineMaintenanceList>();
            try
            {
                reval = StaticData.Data_MachineMaintenanceList.Where(t => t.MachineID == machineID).ToList();
            }
            catch (Exception)
            {

            }
            return reval;
        }
    }
}
