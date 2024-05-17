using Microsoft.AspNetCore.Mvc;
using Service.IService;

namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Quản lý máy
    /// </summary>
    public class MachineManagementController : BaseController
    {
        private readonly IMachineManagementService _machineManagementService;
        public MachineManagementController(IMachineManagementService machineManagementService)
        {
            _machineManagementService = machineManagementService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
