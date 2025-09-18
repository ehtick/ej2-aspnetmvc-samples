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
        // GET: StepArea
        public ActionResult StackedStepArea()
        {
            List<StackedStepAreaChartData> chartData = new List<StackedStepAreaChartData>
            {
                new StackedStepAreaChartData { xValue = 2000, yValue = 416, yValue1 = 180 },
                new StackedStepAreaChartData { xValue = 2001, yValue = 490, yValue1 = 240 },
                new StackedStepAreaChartData { xValue = 2002, yValue = 470, yValue1 = 370 },
                new StackedStepAreaChartData { xValue = 2003, yValue = 500, yValue1 = 200 },
                new StackedStepAreaChartData { xValue = 2004, yValue = 449, yValue1 = 229 },
                new StackedStepAreaChartData { xValue = 2005, yValue = 470, yValue1 = 210 },
                new StackedStepAreaChartData { xValue = 2006, yValue = 437, yValue1 = 337 },
                new StackedStepAreaChartData { xValue = 2007, yValue = 458, yValue1 = 258 },
                new StackedStepAreaChartData { xValue = 2008, yValue = 500, yValue1 = 300 },
                new StackedStepAreaChartData { xValue = 2009, yValue = 473, yValue1 = 173 },
                new StackedStepAreaChartData { xValue = 2010, yValue = 520, yValue1 = 220 },
                new StackedStepAreaChartData { xValue = 2011, yValue = 520, yValue1 = 220 },
            };
            ViewData["dataSource"] = chartData;
            return View();
        }
        public class StackedStepAreaChartData
        {
            public double xValue;
            public double yValue;
            public double yValue1;
        }
    }
}