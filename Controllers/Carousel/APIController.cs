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
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Carousel
{
    public partial class CarouselController : Controller
    {
        public ActionResult API()
        {
            ViewData["showArrowData"] = GetArrowData();
            ViewData["intervalData"] = GetIntervalData();
            return View();
        }
        public class ShowArrow
        {
            public string Arrow { get; set; }
            public string Id { get; set; }
        }
        public List<ShowArrow> GetArrowData()
        {
            List<ShowArrow> arrows = new List<ShowArrow>();
            arrows.Add(new ShowArrow { Arrow = "Hidden", Id = "Hidden" });
            arrows.Add(new ShowArrow { Arrow = "Visible", Id = "Visible" });
            arrows.Add(new ShowArrow { Arrow = "On Hover", Id = "VisibleOnHover" });
            return arrows;
        }
        public class ShowInterval
        {
            public string Interval { get; set; }
            public double Id { get; set; }
        }
        public List<ShowInterval> GetIntervalData()
        {
            List<ShowInterval> intervals = new List<ShowInterval>();
            intervals.Add(new ShowInterval { Interval = "3 Seconds", Id = 3000 });
            intervals.Add(new ShowInterval { Interval = "5 Seconds", Id = 5000 });
            intervals.Add(new ShowInterval { Interval = "7 Seconds", Id = 7000 });
            return intervals;
        }
    }
}