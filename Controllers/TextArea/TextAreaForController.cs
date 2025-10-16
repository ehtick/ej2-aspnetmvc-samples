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
using System.ComponentModel.DataAnnotations;
using Syncfusion.EJ2.Inputs;

namespace EJ2MVCSampleBrowser.Controllers

{
    public class TextAreaModal
    {
        [Required(ErrorMessage = "Value is required")]
        public string comments { get; set; }
    }
    public partial class TextAreaController : Controller
    {
        TextAreaModal textarea = new TextAreaModal();
        // GET: TextAreaFor
        public ActionResult TextAreaFor()
        {
            textarea.comments = "";
            return View(textarea);
        }
        [HttpPost]
        public ActionResult TextAreaFor(TextAreaModal model)
        {
            //posted value is obtained from the model
            textarea.comments = model.comments;
            return View(textarea);
        }
    }
}