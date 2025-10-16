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
        // GET: PolarRadarColumn
        public ActionResult PolarRadarColumn()
        {
            List<PolarColumnData> ChartPoints = new List<PolarColumnData>
            {
                new PolarColumnData { TooltipMappingName= "Japan", Country = "Japan", MobileSubscriber = 137.9, Population = 127.6, NetworkSubscriber = 108.8 },
                new PolarColumnData { TooltipMappingName= "Indonesia", Country = "Indonesia", MobileSubscriber = 85.0, Population = 246.9, NetworkSubscriber = 45.5 },
                new PolarColumnData { TooltipMappingName= "Russia", Country = "Russia", MobileSubscriber = 237.1, Population = 143.5, NetworkSubscriber = 41.2 },
                new PolarColumnData { TooltipMappingName= "Vietnam", Country = "Vietnam", MobileSubscriber = 127.7, Population = 88.8, NetworkSubscriber = 18.0 },
                new PolarColumnData { TooltipMappingName= "Pakistan", Country = "Pakistan", MobileSubscriber = 126.1, Population = 179.2 },
                new PolarColumnData { TooltipMappingName= "Nigeria", Country = "Nigeria", MobileSubscriber = 175.0, Population = 168.8, NetworkSubscriber = 12.7 },
                new PolarColumnData { TooltipMappingName= "Germany", Country = "Germany", MobileSubscriber = 113.6, Population = 81.9, NetworkSubscriber = 46.0 },
                new PolarColumnData { TooltipMappingName= "Bangladesh", Country = "Bangladesh", MobileSubscriber = 116.0, Population = 154.7, NetworkSubscriber = 34.6 },
                new PolarColumnData { TooltipMappingName= "Philippines", Country = "Philippines", MobileSubscriber = 109.5, Population = 96.7, NetworkSubscriber = 16.6 },
                new PolarColumnData { TooltipMappingName= "Mexico", Country = "Mexico", MobileSubscriber = 102.7, Population = 120.8, NetworkSubscriber = 19.8 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["data"] = new string[] { "Polar", "Radar" };
            return View();
        }
        public class PolarColumnData
        {
            public string TooltipMappingName;
            public string Country;
            public double MobileSubscriber;
            public double Population;
            public double NetworkSubscriber;
        }
    }
}