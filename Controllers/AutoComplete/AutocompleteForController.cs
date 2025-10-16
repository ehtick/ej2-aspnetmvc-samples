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
using System.ComponentModel.DataAnnotations;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class AutocompleteModel
    {
        [Required(ErrorMessage = "Value is required")]
        public string val { get; set; }
        public string[] data { get; set; }
    }
    public partial class AutoCompleteController : Controller
    {
        public string[] datasource = new string[] { "American Football", "Badminton", "Basketball", "Cricket", "Football", "Golf", "Hockey", "Rugby", "Snooker", "Tennis" };

        public ActionResult AutocompleteFor()
        {
            AutocompleteModel model = new AutocompleteModel();
            model.data = datasource;
            model.val = "Badminton";
            return View(model);
        }
        [HttpPost]
        public ActionResult AutocompleteFor(AutocompleteModel model)
        {
            //posted value is obtained from the model
            model.data = datasource;
            model.val = model.val;
            return View(model);
        }
    }
}
