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
namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: Reorder
        public ActionResult Reorder()
        {
            var DataSource = EmployeeView.GetAllRecords();
            ViewData["dataSource"] = DataSource;
            List<object> dd = new List<object>();
            dd.Add(new { text = "Employee ID", value = "EmployeeID" });
            dd.Add(new { text = "Name", value = "FirstName" });
            dd.Add(new { text = "Title", value = "Title" });
            dd.Add(new { text = "Hire Date", value = "HireDate" });
            ViewData["columns"] = dd;
            List<object> index = new List<object>();
            index.Add(new { text = "1", value = "0" });
            index.Add(new { text = "2", value = "1" });
            index.Add(new { text = "3", value = "2" });
            index.Add(new { text = "4", value = "3" });
            ViewData["index"] = index;
            return View();
        }
    }
}