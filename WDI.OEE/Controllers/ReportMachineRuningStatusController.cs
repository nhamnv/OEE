using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WDI.OEE.Models;

namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Báo cáo tình trạng hoạt động của máy
    /// </summary>
    public class ReportMachineRuningStatusController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Báo cáo trạng thái hoạt động máy";

            #region // Dropdown Time range
            //var listTimeRange = new List<SelectListItem>();
            //listTimeRange.Add(new SelectListItem() { Text = "Tất cả", Value = "All", Selected = true });

            //listTimeRange.AddRange(
            //    StaticData.TimeRange.Select(t => new SelectListItem()
            //    {
            //        Text = t.TimeRangeName,
            //        Value = t.TimeRangeID.ToString()
            //    })
            //  );

            //ViewData["ListTimeRange"] = listTimeRange;

            #endregion

            #region Dropdown MachineGroup
            var listMachineGroup = new List<SelectListItem>();
            listMachineGroup.Add(new SelectListItem() { Text = "Tất cả", Value = "All", Selected = true });

            listMachineGroup.AddRange(
                StaticData.Data_MachineGroup.AsEnumerable().Select(t => new SelectListItem()
                {
                    Text = t.MachineGroupName,
                    Value = t.MachineGroupID.ToString()
                }
             ));

            ViewData["ListMachineGroup"] = listMachineGroup;

            #endregion

            #region Dropdown Machine Location
            var listLocation = new List<SelectListItem>();

            listLocation.Add(new SelectListItem() { Text = "Tất cả", Value = "All", Selected = true });
            listLocation.AddRange(
                StaticData.Data_MachineLocation.AsEnumerable().Select(t => new SelectListItem()
                {
                    Value = t.LocationID.ToString(),
                    Text = t.LocationName
                })
                );

            ViewData["ListMachineLocation"] = listLocation;

            #endregion


            List<MachineRuningStatusViewModel> model = new List<MachineRuningStatusViewModel>();
            model.Add(new MachineRuningStatusViewModel() { MachineName = "Máy 1 demo" });
            model.Add(new MachineRuningStatusViewModel() { MachineName = "Máy 2 demo" });
            model.Add(new MachineRuningStatusViewModel() { MachineName = "Máy 3 demo" });

            return View(model);
        }


    }
}
