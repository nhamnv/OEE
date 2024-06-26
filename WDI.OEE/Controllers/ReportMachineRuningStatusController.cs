﻿using Common;
using Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.IService;

namespace WDI.OEE.Controllers
{
    /// <summary>
    /// Báo cáo tình trạng hoạt động của máy
    /// </summary>
    public class ReportMachineRuningStatusController : BaseController
    {
        private readonly IReportMachineRuningStatusService _reportMachineRuningStatusService;
        private readonly IRazorPartialToStringRenderer _razorPartialToStringRenderer;
        public ReportMachineRuningStatusController(IReportMachineRuningStatusService reportMachineRuningStatusService, IRazorPartialToStringRenderer razorPartialToStringRenderer)
        {
            _reportMachineRuningStatusService = reportMachineRuningStatusService;
            _razorPartialToStringRenderer = razorPartialToStringRenderer;
        }


        public IActionResult Index()
        {
            ViewData["Title"] = "Trạng thái hoạt động máy";

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

            // mặc định xem dữ liệu 24h gần nhất
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddHours(-24);

            List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, "all", "all");


            return View(model);
        }
        public JsonResult FilterData(string MachineGroupID, string MachineLocationID)
        {
            try
            {
                // mặc định xem dữ liệu 24h gần nhất
                DateTime endDate = DateTime.Now;
                DateTime startDate = endDate.AddHours(-24);

                List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, MachineGroupID, MachineLocationID);

                string machineHTML = "";

                foreach (var data in model)
                {
                    machineHTML += _razorPartialToStringRenderer.RenderPartialToStringAsync("/Views/ReportMachineRuningStatus/_Machine.cshtml", data).Result;
                }

                return new JsonResult(new { success = true, html = machineHTML });
            }
            catch (Exception)
            {

            }
            return new JsonResult("");
        }



        #region Form Detail

        public IActionResult Detail()
        {
            ViewData["Title"] = "Trạng thái hoạt động máy - chi tiết";

            #region Dropdown danh sách máy
            var listTimeRange = new List<SelectListItem>();
            //listTimeRange.Add(new SelectListItem() { Text = "Tất cả", Value = "All", Selected = true });

            listTimeRange.AddRange(
                StaticData.Data_Machine.Select(t => new SelectListItem()
                {
                    Text = t.MachineName,
                    Value = t.MachineID.ToString()
                })
              );

            ViewData["ListMachine"] = listTimeRange;

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

            // mặc định xem dữ liệu 24h gần nhất
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddHours(-24);

            List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, "all", "all");


            return View(model);
        }

        public JsonResult FilterDataDetail(string MachineID, string MachineGroupID, string MachineLocationID)
        {
            try
            {
                // mặc định xem dữ liệu 24h gần nhất
                DateTime endDate = DateTime.Now;
                DateTime startDate = endDate.AddHours(-24);

                List<MachineRuningStatusViewModel> model = _reportMachineRuningStatusService.GetReportMachineRuningStatus(startDate, endDate, MachineGroupID, MachineLocationID, MachineID);

                string machineHTML = "";

                machineHTML += _razorPartialToStringRenderer.RenderPartialToStringAsync("/Views/ReportMachineRuningStatus/_MachineSingle.cshtml", model[0]).Result;

                return new JsonResult(new { success = true, html = machineHTML });
            }
            catch (Exception)
            {

            }
            return new JsonResult("");
        }



        #endregion
    }
}
