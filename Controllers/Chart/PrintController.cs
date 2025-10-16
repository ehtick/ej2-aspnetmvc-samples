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
        // GET: Print
        public ActionResult Print()
        {
            List<PrintChartData> ChartPoints = new List<PrintChartData>
            {
                new PrintChartData { Manager = "John",  SalesInfo = 10, DataLabelMappingName = "$10k" },
                new PrintChartData { Manager = "Jake",  SalesInfo = 12, DataLabelMappingName = "$12k" },
                new PrintChartData { Manager = "Peter", SalesInfo = 18, DataLabelMappingName = "$18k" },
                new PrintChartData { Manager = "James", SalesInfo = 11, DataLabelMappingName = "$11k" },
                new PrintChartData { Manager = "Mary",  SalesInfo = 9.7, DataLabelMappingName = "$9.7k"  }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class PrintChartData
        {
            public string Manager;
            public double SalesInfo;
            public string DataLabelMappingName;
        }
    }
}