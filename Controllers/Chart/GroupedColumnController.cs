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
        // GET: Trendlines
        public ActionResult GroupedColumn()
        {
            List<ColumnData> ChartPoints = new List<ColumnData>
            {
                new ColumnData { Year = "2016", USA_Total = 104, USA_Gold = 46, UK_Total = 65, UK_Gold = 29, China_Total = 91, China_Gold = 38},
                new ColumnData { Year = "2020", USA_Total = 121, USA_Gold = 46, UK_Total = 67, UK_Gold = 27, China_Total = 70, China_Gold = 26},
                new ColumnData { Year = "2024", USA_Total = 113, USA_Gold = 39, UK_Total = 65, UK_Gold = 22, China_Total = 88, China_Gold = 38},
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class ColumnData
        {
            public string Year;
            public double USA_Total;
            public double USA_Gold;
            public double UK_Total;
            public double UK_Gold;
            public double China_Total;
            public double China_Gold;
        }
    }
}