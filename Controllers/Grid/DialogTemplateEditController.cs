#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: DialogTemplateEdit
        public ActionResult DialogTemplateEdit()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewData["datasource"] = order;
            return View();
        }
        public ActionResult Editpartial(DialogTemplateModel value)
        {
            var order = OrdersDetails.GetAllRecords();
            ViewData["datasource"] = order;
            return PartialView("_DialogEditpartial", value);
        }

        public ActionResult AddPartial()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewData["datasource"] = order;
            return PartialView("_DialogAddpartial");
        }
    }
}