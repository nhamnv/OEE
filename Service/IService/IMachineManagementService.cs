using Common.ViewModels;

namespace Service.IService
{
    public interface IMachineManagementService
    {
        /// <summary>
        /// Thống kê máy
        /// </summary>
        /// <returns></returns>
        MachineStatiticsViewModel GetStatitics();

        /// <summary>
        /// Chi tiết máy
        /// </summary>
        /// <param name="machineID"></param>
        /// <param name="machineLocationID"></param>
        /// <returns></returns>
        MachineDetailViewModel GetDetails(int machineID, int machineLocationID);
    }
}
