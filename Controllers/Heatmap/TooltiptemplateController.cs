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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET: Rendermode
        public ActionResult Tooltiptemplate()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewData["border"] = new { width = "0" };
            string[] xlabels = new string[8] { "Canada", "China", "Egypt", "Mexico", "Norway", "Russia", "UK", "USA"};
            ViewData["xLabels"] = xlabels;
            string[] yLabels = new string[11] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010" };
            ViewData["yLabels"] = yLabels;
            ViewData["dataSource"] = new HeatMapData().GetTooltipData();
            return View();
        }
    }
}