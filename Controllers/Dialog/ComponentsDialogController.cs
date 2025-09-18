#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Popups;
using EJ2MVCSampleBrowser.Models;
using System.ComponentModel.DataAnnotations;

namespace EJ2MVCSampleBrowser.Controllers.Dialog
{
    public partial class DialogController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult ComponentsDialog()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new DefaultButtonModels() { content = "OK", isPrimary = true } });
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new DefaultButtonModels() { content = "CANCEL" } });
            ViewData["DefaultButtons"] = buttons;
            var order = OrdersDetails.GetAllRecords();
            ViewData["Datasource"] = order;
            List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 21, yValue1 = 28 },
                new LineChartData { xValue = new DateTime(2006, 01, 01), yValue = 24, yValue1 = 44 },
                new LineChartData { xValue = new DateTime(2007, 01, 01), yValue = 36, yValue1 = 48 },
                new LineChartData { xValue = new DateTime(2008, 01, 01), yValue = 38, yValue1 = 50 },
                new LineChartData { xValue = new DateTime(2009, 01, 01), yValue = 54, yValue1 = 66 },
                new LineChartData { xValue = new DateTime(2010, 01, 01), yValue = 57, yValue1 = 78 },
                new LineChartData { xValue = new DateTime(2011, 01, 01), yValue = 70, yValue1 = 84 },
            };
            ViewData["ChartData"] = chartData;
            ViewData["ScheduleData"] = new ScheduleEvents().GetAppointmentData();
            return View();
        }
    }
    public class DefaultButtonModels
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
    public class LineChartData
    {
        public DateTime xValue;
        public double yValue;
        public double yValue1;
    }
    public class UserModel
    {
        [Required(ErrorMessage = "UserName is Required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Date of Birth is Required")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Addresss is Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }
    }
}