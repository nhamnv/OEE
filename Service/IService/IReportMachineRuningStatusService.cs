using Common.ViewModels;

namespace Service.IService
{
    public interface IReportMachineRuningStatusService
    {
        List<MachineRuningStatusViewModel> GetReportMachineRuningStatus(DateTime StartDate, DateTime EndDate, string MachineGroupID, string MachineLocationID, string MachineID = "");
    }
}
