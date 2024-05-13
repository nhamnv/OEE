using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace WDI.OEE.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        public IActionResult Index()
        {
            @ViewData["Title"] = "Màn hình dashboard";

            DateTime date = DateTime.Now.AddDays(5);

            var model = _dashboardService.GetData(date);

            return View(model);
        }
    }
}
