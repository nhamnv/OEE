using Common.ViewModels;

namespace Service.IService
{
    public interface IMachineManagementService
    {
        MachineSummaryViewModel GetMachineSummaryViewModel(int machineID, int machineLocationID);
    }
}
