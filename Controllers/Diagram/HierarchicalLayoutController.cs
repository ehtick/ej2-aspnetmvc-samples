#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Buttons;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: HierarchicalLayout
        public ActionResult HierarchicalLayout()
        {

            ViewData["Nodes"] = HierarchicalDetails.GetAllRecords();            
            return View();
        }
    }
}