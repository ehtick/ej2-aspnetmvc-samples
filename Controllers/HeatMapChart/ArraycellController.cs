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

namespace EJ2MVCSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        // GET: Arrayrow
        public ActionResult Arraycell()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "inherit"
            };
            ViewData["labelTextStyle"] = new
            {
                fontFamily = "inherit"
            };
            ViewData["border"] = new { color = "white" };
            ViewData["cellTextStyle"] = new { color = "white" , fontFamily= "inherit"};
            string[] xlabels = new string[12] { "China", "India", "Australia", "Mexico", "Canada", "Brazil",
                "USA", "UK", "Germany", "Russia", "France", "Japan"};
            ViewData["xLabels"] = xlabels;
            string[] yLabels = new string[7] { "2000", "2005", "2010", "2011", "2012", "2013", "2014" };
            ViewData["yLabels"] = yLabels;
            double[,] cellData = new double[,]
            {
                {0, 0, 10.75}, {0, 1, 14.5}, {0, 2, 25.5}, {0, 3, 39.5}, {0, 4, 59.75}, {0, 5, 35.50}, {0, 6, 75.5},
                {1, 0, 20.75}, {1, 1, 35.5}, {1, 2, 29.5}, {1, 3, 75.5}, {1, 4, 80}, {1, 5, 65}, {1, 6, 85},
                {2, 0, 6}, {2, 1, 18.5}, {2, 2, 30.05}, {2, 3, 35.5}, {2, 4, 40.75}, {2, 5, 50.75}, {2, 6, 65},
                {3, 0, 30.5}, {3, 1, 20.5}, {3, 2, 45.30}, {3, 3, 50}, {3, 4, 55}, {3, 5, 85.80}, {3, 6, 87.5},
                {4, 0, 10.5}, {4, 1, 20.75}, {4, 2, 35.5}, {4, 3, 35.5}, {4, 4, 45.5}, {4, 5, 65}, {4, 6, 75.5},
                {5, 0, 45.5}, {5, 1, 20.75}, {5, 2, 45.5}, {5, 3, 50.75}, {5, 4, 79.30}, {5, 5, 84.20}, {5, 6, 87.36},
                {6, 0, 26.82}, {6, 1, 70}, {6, 2, 75}, {6, 3, 79.5}, {6, 4, 88.5}, {6, 5, 89.5}, {6, 6, 91.75},
                {7, 0, 15.75}, {7, 1, 20.75}, {7, 2, 25.5}, {7, 3, 42.35}, {7, 4, 45.15}, {7, 5, 76.5}, {7, 6, 80.5},
                {8, 0, 1.98}, {8, 1, 15.23}, {8, 2, 43}, {8, 3, 49}, {8, 4, 63.80}, {8, 5, 67.97}, {8, 6, 70.52},
                {9, 0, 14.31}, {9, 1, 42.87}, {9, 2, 77.28}, {9, 3, 77.82}, {9, 4, 81.44}, {9, 5, 81.92}, {9, 6, 83.75},
                {10, 0, 25.5}, {10, 1, 35.5}, {10, 2, 40.5}, {10, 3, 45.05}, {10, 4, 50.5}, {10, 5, 75.5}, {10, 6, 90.58}
            };
            ViewData["dataSource"] = cellData;

            return View();
        }
    }
}