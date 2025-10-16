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
        // GET: PieRadius
        public ActionResult PieRadius()
        {
            List<PieRadiusChartData> ChartPoints = new List<PieRadiusChartData>
            {
                new PieRadiusChartData { Country = "Cuba",       Population = 103800, Radius = "106", text = "CUB" },
                new PieRadiusChartData { Country = "Syria",      Population = 185178, Radius = "133", text = "SYR" },
                new PieRadiusChartData { Country = "Benin",      Population = 112760, Radius = "128", text = "BEN" },
                new PieRadiusChartData { Country = "Portugal",   Population = 91606,  Radius = "114", text = "POR" },
                new PieRadiusChartData { Country = "Austria",    Population = 82520,  Radius = "111", text = "AUS" },
                new PieRadiusChartData { Country = "Honduras",   Population = 111890, Radius = "97",  text = "HON" },
                new PieRadiusChartData { Country = "Azerbaijan", Population = 82650,  Radius = "125", text = "AZE" }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class PieRadiusChartData
        {
            public string Country;
            public double Population;
            public string Radius;
            public string text;
            
        }
    }
}