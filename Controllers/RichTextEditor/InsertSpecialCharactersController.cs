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
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult InsertSpecialCharacters()
        {
           
            var tools = new
            {
                tooltipText = "Insert Symbol",
                template = "<button class='e-tbar-btn e-btn' tabindex='-1' id='custom_tbar'  style='width:100%'><div class='e-tbar-btn-text rtecustomtool' style='font-weight: 400;'> &#937;</div></button>"
            };
            ViewData["Items"] = new object[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "Blockquote", "OrderedList",
        "UnorderedList", "|", "CreateLink", "Image", "CreateTable", "|", "SourceCode", tools
        , "|", "Undo", "Redo"
            };
            ViewData["InsertBtn"] = new
            {
                content = "Insert",
                isPrimary = true
            };
            ViewData["CancelBtn"] = new
            {
                content = "Cancel"
            };

            return View();
        }
    }
}
