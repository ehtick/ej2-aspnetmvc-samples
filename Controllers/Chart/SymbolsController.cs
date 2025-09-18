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
        // GET: Symbols
        public ActionResult Symbols()
        {
            List<SymbolsData> ChartPoints = new List<SymbolsData>
            {
                new SymbolsData { Country = "World Wide", FBUser_07 = 12, FBUser_08 = 22, FBUser_09 = 38.3, TooltipMappingName = "World Wide"},
                new SymbolsData { Country = "Europe", FBUser_07 = 9.9, FBUser_08 = 26, FBUser_09 = 45.2, TooltipMappingName = "Europe" },
                new SymbolsData { Country = "Asia Pacific", FBUser_07 = 6.4, FBUser_08 = 9.6, FBUser_09 = 18.2, TooltipMappingName = "Asia Pacific"},
                new SymbolsData { Country = "Latin America", FBUser_07 = 4.4, FBUser_08 = 28, FBUser_09 = 46.7, TooltipMappingName = "Latin America"},
                new SymbolsData { Country = "Middle East Africa", FBUser_07 = 30, FBUser_08 = 45.7, FBUser_09 = 61.5, TooltipMappingName = "Middle East Africa"},
                new SymbolsData { Country = "North America", FBUser_07 = 25.3, FBUser_08 = 35.9, FBUser_09 = 64, TooltipMappingName = "North America"},
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class SymbolsData
        {
            public string Country;
            public double FBUser_07;
            public double FBUser_08;
            public double FBUser_09;
            public string TooltipMappingName;
        }
    }
}