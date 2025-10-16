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

namespace EJ2MVCSampleBrowser.Controllers.Treemap
{
    public partial class TreemapController : Controller
    {
        // GET: Customization
        public ActionResult Customization()
        {
            ViewData["imagedata"] = "<div><img src='../Content/Treemap/{{:GameImage}}')' style='height:{{:ItemHeight}};width:{{:ItemWidth}};'/></div>";
            return View();
        }
    }
}