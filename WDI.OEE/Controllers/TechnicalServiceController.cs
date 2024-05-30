using Microsoft.AspNetCore.Mvc;

namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Dịch vụ kỹ thuật
    /// </summary>
    public class TechnicalServiceController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        #region Dịch vụ bảo dưỡng

        public IActionResult FormExecuteChecklist()
        {


            return View();
        }

        #endregion
    }
}
