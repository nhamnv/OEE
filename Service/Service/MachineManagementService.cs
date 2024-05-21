using Common.ViewModels;
using Service.IService;

namespace Service.Service
{
    public class MachineManagementService : IMachineManagementService
    {
        public MachineSummaryViewModel GetMachineSummaryViewModel(int machineID, int machineLocationID)
        {
            MachineSummaryViewModel reval = new MachineSummaryViewModel();

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
                    new ChartItemViewModel() {Name="AH1", Value=10, ColorCode="#FFFFFF"},
                    new ChartItemViewModel() {Name="AH2", Value=28, ColorCode="#FFFFFF"},
                    new ChartItemViewModel() {Name="AH3", Value=5, ColorCode="#FFFFFF"}
                }
            };

            // Box - Số máy theo nhóm
            reval.BoxTotalMachineByGroup = new BoxData()
            {
                Title = "Số máy theo nhóm",
                Value = 43,
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="GCN", Value=10, ColorCode="#FFFFFF"},
                    new ChartItemViewModel() {Name="DCTH", Value=25, ColorCode="#FFFFFF"},
                    new ChartItemViewModel() {Name="LASER", Value=1, ColorCode="#FFFFFF"},
                    new ChartItemViewModel() {Name="PLASMA", Value=5, ColorCode="#FFFFFF"},
                    new ChartItemViewModel() {Name="ROBOT", Value=2, ColorCode="#FFFFFF"},
                }
            };

            // Pie Chart - Tỷ lệ máy theo từng xưởng
            reval.PieChartRateOfTotalMachineByWorkshop = new ChartData()
            {
                Title = "Tỷ lệ máy theo từng xưởng",
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="AH1", Value=23.26, ColorCode="#E17084"},
                    new ChartItemViewModel() {Name="AH2", Value=56.12, ColorCode="#6aa1e4"},
                    new ChartItemViewModel() {Name="AH3", Value=11.63, ColorCode="#f1cf6d"}
                }
            };

            // Pie Chart - Tỷ lệ máy theo nhóm máy
            reval.PieChartRateOfTotalMachineByGroup = new ChartData()
            {
                Title = "Tỷ lệ máy theo từng xưởng",
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="GCN", Value=23.26, ColorCode="#E17084"},
                    new ChartItemViewModel() {Name="DCTH", Value=58.14, ColorCode="#6aa1e4"},
                    new ChartItemViewModel() {Name="LASER", Value=2.33, ColorCode="#f1cf6d"},
                    new ChartItemViewModel() {Name="PLASMA", Value=11.63, ColorCode="#73c84f"},
                    new ChartItemViewModel() {Name="ROBOT", Value=4.65, ColorCode="#df4d26"},
                }
            };

            // Pie Chart - Tỷ lệ máy theo nhóm tài sản
            reval.PieChartRateOfTotalMachineByAssetGroup = new ChartData()
            {
                Title = "Tỷ lệ máy theo nhóm tài sản",
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="Máy cắt", Value=18.6, ColorCode="#e17084"},
                    new ChartItemViewModel() {Name="Máy cưa", Value=2.33, ColorCode="#6aa1e4"},
                    new ChartItemViewModel() {Name="Máy khoan", Value=4.65, ColorCode="#f1cf6d"},
                    new ChartItemViewModel() {Name="Máy phay", Value=6.98, ColorCode="#73c84f"},
                    new ChartItemViewModel() {Name="Máy lốc, uốn, gấp mép, xoay ống", Value=4.65, ColorCode="#df4d26"},
                    new ChartItemViewModel() {Name="Máy ráp dầm, H/I-Đính, Gá, Lật, VC dầm", Value=23.26, ColorCode="#6798f7"},
                    new ChartItemViewModel() {Name="Máy nắn thẳng", Value=4.65, ColorCode="#5c360f"},
                    new ChartItemViewModel() {Name="Máy hàn cổng", Value=34.88, ColorCode="#696796"}
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
                            new ChartItemViewModel() {Name="GCN", Value=2, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="DCTH", Value=9, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="LASER", Value=7, ColorCode="#f1cf6d"},
                            new ChartItemViewModel() {Name="PLASMA", Value=11, ColorCode="#73c84f"},
                            new ChartItemViewModel() {Name="ROBOT", Value=4, ColorCode="#df4d26"},
                        }
                    },
                    new ChartData()
                    {
                        Title="AH2",
                        ColorCode="#6aa1e4",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=14, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="DCTH", Value=3, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="LASER", Value=4, ColorCode="#f1cf6d"},
                            new ChartItemViewModel() {Name="PLASMA", Value=9, ColorCode="#73c84f"},
                            new ChartItemViewModel() {Name="ROBOT", Value=12, ColorCode="#df4d26"},
                        }
                    },
                    new ChartData()
                    {
                        Title="AH3",
                        ColorCode="#f1cf6d",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=6, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="DCTH", Value=1, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="LASER", Value=0, ColorCode="#f1cf6d"},
                            new ChartItemViewModel() {Name="PLASMA", Value=2, ColorCode="#73c84f"},
                            new ChartItemViewModel() {Name="ROBOT", Value=0, ColorCode="#df4d26"},
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
                            new ChartItemViewModel() {Name="AH1", Value=14, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="AH2", Value=17, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="AH3", Value=6, ColorCode="#f1cf6d"}
                        }
                    },
                    new ChartData()
                    {
                        Title="DCTH",
                        ColorCode ="#6aa1e4",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=3, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="AH2", Value=6, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="AH3", Value=15, ColorCode="#f1cf6d"}
                        }
                    },
                    new ChartData()
                    {
                        Title="LASER",
                        ColorCode ="#f1cf6d",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=12, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="AH2", Value=4, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="AH3", Value=18, ColorCode="#f1cf6d"}
                        }
                    },
                    new ChartData()
                    {
                        Title="PLASMA",
                        ColorCode ="#73c84f",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=8, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="AH2", Value=16, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="AH3", Value=1, ColorCode="#f1cf6d"}
                        }
                    },
                    new ChartData()
                    {
                        Title="ROBOT",
                        ColorCode ="#df4d26",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=27, ColorCode="#E17084"},
                            new ChartItemViewModel() {Name="AH2", Value=4, ColorCode="#6aa1e4"},
                            new ChartItemViewModel() {Name="AH3", Value=18, ColorCode="#f1cf6d"}
                        }
                    },
                }
            };

            #endregion

            return reval;
        }
    }
}
