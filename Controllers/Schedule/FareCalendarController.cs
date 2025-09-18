#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult FareCalendar()
        {
            List<AirelineData> airlines = new List<AirelineData>();
            airlines.Add(new AirelineData { Text = "Airways 1", Id = 1 });
            airlines.Add(new AirelineData { Text = "Airways 2", Id = 2 });
            airlines.Add(new AirelineData { Text = "Airways 3", Id = 3 });
            ViewData["airlines"] = airlines;
            return View();
        }
    }

    internal class AirelineData
    {
        public string Text { set; get; }
        public int Id { set; get; }
    }
}