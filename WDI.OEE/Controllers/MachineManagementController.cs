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
        /// Thống kê số lượng máy
        /// </summary>
        /// <param name="stringData">string dạng JObject</param>
        /// <returns></returns>
        public ActionResult Statitics(string stringData)
        {
            MachineStatiticsViewModel model = new MachineStatiticsViewModel();
            ViewData["Title"] = "Thống kê số lượng máy";

            try
            {
                //dynamic d = JObject.Parse(stringData);
                //int machineID = d.machineID;
                //int machineLocationID = d.machineLocationID;

                model = _machineManagementService.GetStatitics();
            }
            catch (Exception ex)
            {

            }

            return View(model);
        }

        public ActionResult MachineDetail(string stringData)
        {
            MachineDetailViewModel model = new MachineDetailViewModel();
            ViewData["Title"] = "Xem chi tiết máy";

            try
            {
                dynamic d = JObject.Parse(stringData);
                int machineID = d.machineID;
                int machineLocationID = d.machineLocationID;

                model = _machineManagementService.GetDetails(machineID, machineLocationID);
            }
            catch (Exception ex)
            {

            }

            return View(model);
        }

    }
}
