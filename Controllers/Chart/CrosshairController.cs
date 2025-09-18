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
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Crosshair
        public ActionResult Crosshair()
        {
            List<CrosshairChartData> chartData = new List<CrosshairChartData>
            {
                new CrosshairChartData { Time = "09:00", Value = 289.92 },
                new CrosshairChartData { Time = "09:05", Value = 289.33 },
                new CrosshairChartData { Time = "09:10", Value = 289.73 },
                new CrosshairChartData { Time = "09:15", Value = 299.39 },
                new CrosshairChartData { Time = "09:20", Value = 298.95 },
                new CrosshairChartData { Time = "09:25", Value = 297.14 },
                new CrosshairChartData { Time = "09:30", Value = 297.13 },
                new CrosshairChartData { Time = "09:35", Value = 296.63 },
                new CrosshairChartData { Time = "09:40", Value = 293.42 },
                new CrosshairChartData { Time = "09:45", Value = 295.84 },
                new CrosshairChartData { Time = "09:50", Value = 297.90 },
                new CrosshairChartData { Time = "09:55", Value = 298.07 },
                new CrosshairChartData { Time = "10:00", Value = 300.50 },
                new CrosshairChartData { Time = "10:05", Value = 300.75 },
                new CrosshairChartData { Time = "10:10", Value = 301.39 },
                new CrosshairChartData { Time = "10:15", Value = 305.91 },
                new CrosshairChartData { Time = "10:20", Value = 305.19 },
                new CrosshairChartData { Time = "10:25", Value = 304.72 },
                new CrosshairChartData { Time = "10:30", Value = 304.40 },
                new CrosshairChartData { Time = "10:35", Value = 303.64 },
                new CrosshairChartData { Time = "10:40", Value = 302.80 },
                new CrosshairChartData { Time = "10:45", Value = 302.08 },
                new CrosshairChartData { Time = "10:50", Value = 301.90 },
                new CrosshairChartData { Time = "10:55", Value = 300.62 },
                new CrosshairChartData { Time = "11:00", Value = 297.24 },
                new CrosshairChartData { Time = "11:05", Value = 297.49 },
                new CrosshairChartData { Time = "11:10", Value = 297.37 },
                new CrosshairChartData { Time = "11:15", Value = 297.10 },
                new CrosshairChartData { Time = "11:20", Value = 296.84 },
                new CrosshairChartData { Time = "11:25", Value = 296.07 },
                new CrosshairChartData { Time = "11:30", Value = 292.96 },
                new CrosshairChartData { Time = "11:35", Value = 296.05 },
                new CrosshairChartData { Time = "11:40", Value = 294.97 },
                new CrosshairChartData { Time = "11:45", Value = 297.45 },
                new CrosshairChartData { Time = "11:50", Value = 291.37 },
                new CrosshairChartData { Time = "11:55", Value = 296.01 },
                new CrosshairChartData { Time = "12:00", Value = 294.21 },
                new CrosshairChartData { Time = "12:05", Value = 294.77 },
                new CrosshairChartData { Time = "12:10", Value = 293.22 },
                new CrosshairChartData { Time = "12:15", Value = 293.50 },
                new CrosshairChartData { Time = "12:20", Value = 293.78 },
                new CrosshairChartData { Time = "12:25", Value = 295.67 },
                new CrosshairChartData { Time = "12:30", Value = 294.68 },
                new CrosshairChartData { Time = "12:35", Value = 294.21 },
                new CrosshairChartData { Time = "12:40", Value = 293.31 },
                new CrosshairChartData { Time = "12:45", Value = 298.67 },
                new CrosshairChartData { Time = "12:50", Value = 292.96 },
                new CrosshairChartData { Time = "12:55", Value = 293.29 },
                new CrosshairChartData { Time = "13:00", Value = 293.65 },
                new CrosshairChartData { Time = "13:05", Value = 293.60 },
                new CrosshairChartData { Time = "13:10", Value = 293.43 },
                new CrosshairChartData { Time = "13:15", Value = 292.48 },
                new CrosshairChartData { Time = "13:20", Value = 292.21 },
                new CrosshairChartData { Time = "13:25", Value = 291.46 },
                new CrosshairChartData { Time = "13:30", Value = 292.20 },
                new CrosshairChartData { Time = "13:35", Value = 293.68 },
                new CrosshairChartData { Time = "13:40", Value = 291.76 },
                new CrosshairChartData { Time = "13:45", Value = 291.40 },
                new CrosshairChartData { Time = "13:50", Value = 290.75 },
                new CrosshairChartData { Time = "13:55", Value = 294.13 },
                new CrosshairChartData { Time = "14:00", Value = 296.75 },
                new CrosshairChartData { Time = "14:05", Value = 297.97 },
                new CrosshairChartData { Time = "14:10", Value = 299.41 },
                new CrosshairChartData { Time = "14:15", Value = 300.87 },
                new CrosshairChartData { Time = "14:20", Value = 300.82 },
                new CrosshairChartData { Time = "14:25", Value = 301.87 },
                new CrosshairChartData { Time = "14:30", Value = 300.80 },
                new CrosshairChartData { Time = "14:35", Value = 301.33 },
                new CrosshairChartData { Time = "14:40", Value = 301.83 },
                new CrosshairChartData { Time = "14:45", Value = 303.68 },
                new CrosshairChartData { Time = "14:50", Value = 303.01 },
                new CrosshairChartData { Time = "14:55", Value = 303.97 },
                new CrosshairChartData { Time = "15:00", Value = 303.86 },
                new CrosshairChartData { Time = "15:05", Value = 306.28 },
                new CrosshairChartData { Time = "15:10", Value = 304.54 },
                new CrosshairChartData { Time = "15:15", Value = 304.23 },
                new CrosshairChartData { Time = "15:20", Value = 301.14 },
                new CrosshairChartData { Time = "15:25", Value = 302.12 },
                new CrosshairChartData { Time = "15:30", Value = 301.91 },
                new CrosshairChartData { Time = "15:35", Value = 304.58 },
                new CrosshairChartData { Time = "15:40", Value = 302.32 },
                new CrosshairChartData { Time = "15:45", Value = 302.89 },
                new CrosshairChartData { Time = "15:50", Value = 302.45 },
                new CrosshairChartData { Time = "15:55", Value = 302.12 },
                new CrosshairChartData { Time = "16:00", Value = 302.76 },
                new CrosshairChartData { Time = "16:05", Value = 303.23 },
                new CrosshairChartData { Time = "16:10", Value = 303.98 },
                new CrosshairChartData { Time = "16:15", Value = 304.54 },
                new CrosshairChartData { Time = "16:20", Value = 304.01 },
                new CrosshairChartData { Time = "16:25", Value = 304.67 },
                new CrosshairChartData { Time = "16:30", Value = 305.12 },
                new CrosshairChartData { Time = "16:35", Value = 305.45 },
                new CrosshairChartData { Time = "16:40", Value = 306.23 },
                new CrosshairChartData { Time = "16:45", Value = 306.87 },
                new CrosshairChartData { Time = "16:50", Value = 306.32 },
                new CrosshairChartData { Time = "16:55", Value = 307.98 },
                new CrosshairChartData { Time = "17:00", Value = 310.65 },
                new CrosshairChartData { Time = "17:05", Value = 309.43 },
                new CrosshairChartData { Time = "17:10", Value = 308.21 },
                new CrosshairChartData { Time = "17:15", Value = 307.89 },
                new CrosshairChartData { Time = "17:20", Value = 307.54 },
                new CrosshairChartData { Time = "17:25", Value = 305.32 },
                new CrosshairChartData { Time = "17:30", Value = 305.76 },
                new CrosshairChartData { Time = "17:35", Value = 304.23 },
                new CrosshairChartData { Time = "17:40", Value = 304.65 },
                new CrosshairChartData { Time = "17:45", Value = 304.01 },
                new CrosshairChartData { Time = "17:50", Value = 304.43 },
                new CrosshairChartData { Time = "17:55", Value = 305.76 },
                new CrosshairChartData { Time = "18:00", Value = 305.12 },
                new CrosshairChartData { Time = "18:05", Value = 306.45 },
                new CrosshairChartData { Time = "18:10", Value = 306.23 },
                new CrosshairChartData { Time = "18:15", Value = 304.98 },
                new CrosshairChartData { Time = "18:20", Value = 304.65 },
                new CrosshairChartData { Time = "18:25", Value = 304.32 },
                new CrosshairChartData { Time = "18:30", Value = 304.98 },
                new CrosshairChartData { Time = "18:35", Value = 303.65 },
                new CrosshairChartData { Time = "18:40", Value = 303.32 },
                new CrosshairChartData { Time = "18:45", Value = 303.01 },
                new CrosshairChartData { Time = "18:50", Value = 302.76 },
                new CrosshairChartData { Time = "18:55", Value = 301.54 },
                new CrosshairChartData { Time = "19:00", Value = 301.32 },
                new CrosshairChartData { Time = "19:05", Value = 301.21 },
                new CrosshairChartData { Time = "19:10", Value = 300.43 },
                new CrosshairChartData { Time = "19:15", Value = 300.76 },
                new CrosshairChartData { Time = "19:20", Value = 301.12 },
                new CrosshairChartData { Time = "19:25", Value = 301.54 },
                new CrosshairChartData { Time = "19:30", Value = 300.89 },
                new CrosshairChartData { Time = "19:35", Value = 300.23 },
                new CrosshairChartData { Time = "19:40", Value = 300.56 },
                new CrosshairChartData { Time = "19:45", Value = 299.87 }
            };
            ViewData["ChartData"] = chartData;
            return View();
        }
        public class CrosshairChartData
        {
            public string Time;
            public double Value;
        }
    }
}