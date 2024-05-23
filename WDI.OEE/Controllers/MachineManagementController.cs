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

        /// <summary>
        /// Load chi tiết máy
        /// </summary>
        /// <param name="stringData">
        /// Json data gồm các trường:
        /// <para>machineID: id máy</para>
        /// <para>machineLocationID: id vị trí lắp máy</para>
        /// <para>formType: kiểu form: 1=load to view; 2=load to edit</para>
        /// </param>
        /// <returns></returns>
        public ActionResult MachineDetail(string stringData)
        {
            MachineDetailViewModel model = new MachineDetailViewModel();
            ViewData["Title"] = "Xem chi tiết máy";

            try
            {
                dynamic d = JObject.Parse(stringData);
                int machineID = d.machineID;
                int machineLocationID = d.machineLocationID;
                int formType = d.formType;

                model = _machineManagementService.GetDetails(machineID, machineLocationID);
            }
            catch (Exception ex)
            {

            }

            return View(model);
        }

    }
}
