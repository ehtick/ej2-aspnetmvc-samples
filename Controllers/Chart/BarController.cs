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
        // GET: Bar
        public ActionResult Bar()
        {
            List<BarChartData> ChartPoints = new List<BarChartData>
            {
                new BarChartData { Year = "2021",  Count1 = 237, Count2 = 190, Count3 = 143 },
                new BarChartData { Year = "2022",  Count1 = 226.4, Count2 = 153.1, Count3 = 103.3 },
                new BarChartData { Year = "2023",  Count1 = 234.6, Count2 = 145.9, Count3 = 103.1 },
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class BarChartData
        {
            public string Year;
            public double Count1;
            public double Count2;
            public double Count3;
        }
    }
}