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
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.ContextMenu
{
    public partial class ContextMenuController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            List<ContextMenuItem> menuitems = new List<ContextMenuItem>() {
                new ContextMenuItem{ Text="Cut", IconCss="e-cm-icons e-cut" },
                new ContextMenuItem{ Text="Copy", IconCss="e-cm-icons e-copy" },
                new ContextMenuItem{ Text="Paste", IconCss="e-cm-icons e-paste",
                    Items = new List<ContextMenuItem>(){
                        new ContextMenuItem{ Text = "Paste Text", IconCss = "e-cm-icons e-pastetext" },
                        new ContextMenuItem{ Text = "Paste Special", IconCss = "e-cm-icons e-pastespecial" }
                    }
                },
                new ContextMenuItem{ Separator= true},
                new ContextMenuItem{ Text = "Link", IconCss = "e-cm-icons e-link"},
                new ContextMenuItem{ Text = "New Comment", IconCss = "e-cm-icons e-comment"}
            };

            ViewData["menuitems"] = menuitems;
            return View();
        }
      }
    }