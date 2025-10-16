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
        // GET: StackedBar100
        public ActionResult StackedBar100()
        {
            List<StackedBar100ChartData> ChartPoints = new List<StackedBar100ChartData>
            {
                new StackedBar100ChartData { X = "2020", Y1 = 466, Y2 = 261, Y3 = 1355 },
                new StackedBar100ChartData { X = "2021", Y1 = 656, Y2 = 327, Y3 = 1340 },
                new StackedBar100ChartData { X = "2022", Y1 = 763, Y2 = 427, Y3 = 1352 },
                new StackedBar100ChartData { X = "2023", Y1 = 886, Y2 = 584, Y3 = 1286 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class StackedBar100ChartData
        {
            public string X;
            public double Y1;
            public double Y2;
            public double Y3;
        }
    }
}