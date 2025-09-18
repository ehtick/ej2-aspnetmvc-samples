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

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class ComboBoxController : Controller
    {
        public ActionResult DataBinding()
        {
            ViewData["localdata"] = new GameList().GameLists();
            ViewData["sort"] = "Ascending";
            ViewData["query"] = "new ej.data.Query().select(['FirstName', 'EmployeeID']).take(10).requiresCount()";
            return View();
        }
    }
}