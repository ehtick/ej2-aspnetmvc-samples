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
        public ActionResult StepArea()
        {
            List<StepAreaChartData> ChartPoints = new List<StepAreaChartData>
            {
                new StepAreaChartData { Period = 2000, RenewableResourcesProduction = 416, NonRenewableResourcesProduction = 180 },
                new StepAreaChartData { Period = 2001, RenewableResourcesProduction = 490, NonRenewableResourcesProduction = 240 },
                new StepAreaChartData { Period = 2002, RenewableResourcesProduction = 470, NonRenewableResourcesProduction = 370 },
                new StepAreaChartData { Period = 2003, RenewableResourcesProduction = 500, NonRenewableResourcesProduction = 200 },
                new StepAreaChartData { Period = 2004, RenewableResourcesProduction = 449, NonRenewableResourcesProduction = 229 },
                new StepAreaChartData { Period = 2005, RenewableResourcesProduction = 470, NonRenewableResourcesProduction = 210 },
                new StepAreaChartData { Period = 2006, RenewableResourcesProduction = 437, NonRenewableResourcesProduction = 337 },
                new StepAreaChartData { Period = 2007, RenewableResourcesProduction = 458, NonRenewableResourcesProduction = 258 },
                new StepAreaChartData { Period = 2008, RenewableResourcesProduction = 500, NonRenewableResourcesProduction = 300 },
                new StepAreaChartData { Period = 2009, RenewableResourcesProduction = 473, NonRenewableResourcesProduction = 173 },
                new StepAreaChartData { Period = 2010, RenewableResourcesProduction = 520, NonRenewableResourcesProduction = 220 },
                new StepAreaChartData { Period = 2011, RenewableResourcesProduction = 520, NonRenewableResourcesProduction = 220 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class StepAreaChartData
        {
            public double Period;
            public double RenewableResourcesProduction;
            public double NonRenewableResourcesProduction;
        }
    }
}