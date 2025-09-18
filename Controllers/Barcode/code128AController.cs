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
using Syncfusion.EJ2.BarcodeGenerator;

namespace EJ2CoreSampleBrowser.Controllers.Barcode
{
    public partial class BarcodeController : Controller
    {
        
        public ActionResult Code128A()
        {
            List<ExpandOptionsCode128A> position = new List<ExpandOptionsCode128A>();
            position.Add(new ExpandOptionsCode128A() { text = "Bottom", value = "bottom" });
            position.Add(new ExpandOptionsCode128A() { text = "Top", value = "top" });

            ViewData["position"] = position;

            List<ExpandOptionsCode128A> alignment = new List<ExpandOptionsCode128A>();
            alignment.Add(new ExpandOptionsCode128A() { text = "Center", value = "Center" });
            alignment.Add(new ExpandOptionsCode128A() { text = "Left", value = "Left" });
            alignment.Add(new ExpandOptionsCode128A() { text = "Right", value = "Right" });

            ViewData["alignment"] = alignment;
            ViewData["expandValue"] = "Bottom";
            return View();
        }
    }

    public class ExpandOptionsCode128A
    {
        public string text;
        public string value;
    }
    
}