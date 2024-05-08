using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace WDI.OEE.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController()
        {
            
        }
        public IActionResult Index()
        {
            @ViewData["Title"] = "Màn hình dashboard";
            return View();
        }
    }
}
