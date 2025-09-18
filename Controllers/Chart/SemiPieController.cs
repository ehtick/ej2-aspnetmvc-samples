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
        // GET: SemiPie
        public ActionResult SemiPie()
        {
            List<SemiPieChartData> PieChartPoints = new List<SemiPieChartData>
            {
                new SemiPieChartData { Browser =  "Chrome", Users = 100, DataLabelMappingName = "Chrome (100M)<br>40%", tooltipMappingName="40%" },
                new SemiPieChartData { Browser =  "UC Browser", Users = 40, DataLabelMappingName = "UC Browser (40M)<br>16%", tooltipMappingName="16%" },
                new SemiPieChartData { Browser =  "Opera", Users = 30, DataLabelMappingName = "Opera (30M)<br>12%", tooltipMappingName="12%" },
                new SemiPieChartData { Browser =  "Safari", Users = 30, DataLabelMappingName = "Safari (30M)<br>12%", tooltipMappingName="12%" },
                new SemiPieChartData { Browser =  "Firefox", Users = 25, DataLabelMappingName = "Firefox (25M)<br>10%", tooltipMappingName="10%" },
                new SemiPieChartData { Browser =  "Others", Users = 25, DataLabelMappingName = "Others (25M)<br>10%", tooltipMappingName="10%" }
            };
            ViewData["PieChartPoints"] = PieChartPoints;
            return View();
        }
        public class SemiPieChartData
        {
            public string Browser;
            public double Users;
            public string DataLabelMappingName;
            public string tooltipMappingName;
        }
    }
}