using Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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

        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// Xem tổng quan máy
        /// </summary>
        /// <param name="stringData">string dạng JObject</param>
        /// <returns></returns>
        public ActionResult MachineDetail(string stringData)
        {
            MachineSummaryViewModel model = new MachineSummaryViewModel();
            ViewData["Title"] = "Thống kê số lượng máy";

            try
            {
                dynamic d = JObject.Parse(stringData);
                int machineID = d.machineID;
                int machineLocationID = d.machineLocationID;

                model = _machineManagementService.GetMachineSummaryViewModel(machineID, machineLocationID);
            }
            catch (Exception ex)
            {

            }

            return View(model);
        }

    }
}
