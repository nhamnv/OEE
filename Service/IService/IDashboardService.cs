using Common.ViewModels;

namespace Service.IService
{
    public interface IDashboardService
    {
        DashboardViewModel GetData(DateTime repotDate);
    }
}
