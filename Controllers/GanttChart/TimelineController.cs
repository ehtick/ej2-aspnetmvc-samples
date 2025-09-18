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
using EJ2MVCSampleBrowser.Models;
namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: Timeline
        public ActionResult Timeline()
        {
            ViewData["DataSource"] = GanttData.TimelineData();
            ViewData["Resources"] = GanttData.TimelineResources();
            ViewData["WeekFormat"] = DayFormat.GetWeekFormat();
            ViewData["DayFormat"] = DayFormat.GetDayFormat();
            ViewData["Units"] = TimelineUnit.GetUnits();
            return View();
        }
        public class DayFormat
        {
            public string Id { get; set; }
            public string Format { get; set; }


            public static List<DayFormat> GetWeekFormat()
            {
                List<DayFormat> formats = new List<DayFormat>();
                formats.Add(new DayFormat() { Id = "MMM dd, yyyy", Format = "Jan 01, 2019" });
                formats.Add(new DayFormat() { Id = "EEE MMM dd, 'yy", Format = "Mon Jan 01, '19" });
                formats.Add(new DayFormat() { Id = "EEE MMM dd", Format = "Mon Jan 01" });
                return formats;
            }

            public static List<DayFormat> GetDayFormat()
            {
                List<DayFormat> formats = new List<DayFormat>();
                formats.Add(new DayFormat() { Id = "EEE, dd", Format = "Mon, 01" });
                formats.Add(new DayFormat() { Id = "EEE", Format = "Mon" });
                formats.Add(new DayFormat() { Id = "dd", Format = "01" });
                formats.Add(new DayFormat() { Id = "E", Format = "M" });
                return formats;
            }
        }

        public class TimelineUnit
        {
            public string Id { get; set; }
            public string Unit { get; set; }
            public static List<TimelineUnit> GetUnits()
            {
                List<TimelineUnit> units = new List<TimelineUnit>();
                units.Add(new TimelineUnit() { Id = "Year", Unit = "Year" });
                units.Add(new TimelineUnit() { Id = "Month", Unit = "Month" });
                units.Add(new TimelineUnit() { Id = "Week", Unit = "Week" });
                units.Add(new TimelineUnit() { Id = "Day", Unit = "Day" });
                units.Add(new TimelineUnit() { Id = "Hour", Unit = "Hour" });
                return units;
            }
        }
    }
}