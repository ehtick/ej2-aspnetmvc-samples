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

namespace EJ2MVCSampleBrowser.Controllers.Menu
{
    public partial class MenuController : Controller
    {
        // GET: Api
        public ActionResult Api()
        {
            List<object> data = new List<object>() {
                new {
                    header = "Events",
                    subItems = new List<object>() {
                        new { text= "Conferences" },
                        new { text= "Music" },
                        new { text= "Workshops" }
                    }
                },
                new {
                    header = "Movies",
                    subItems = new List<object>() {
                        new { text= "Now Showing" },
                        new { text= "Coming Soon" }
                    }
                },
                new {
                    header = "Directory",
                    subItems = new List<object>() {
                        new { text= "Media Gallery" },
                        new { text= "Newsletters" }
                    }
                },
                new {
                    header = "Queries",
                    subItems = new List<object>() {
                        new { text= "Our Policy" },
                        new { text= "Site Map"},
                        new { text= "24x7 Support"}
                    }
                },
                new { header= "Services" }
            };

            MenuFieldSettings menuFields = new MenuFieldSettings()
            {
                IconCss = "icon",
                Text = new string[] { "header", "text", "value" },
                Children = new string[] { "subItems", "options" }
            };

            List<object> headerData = new List<object>()
            {
                new { text= "Events" },
                new { text= "Movies"},
                new { text= "Directory" },
                new {text= "Queries" },
                new { text= "Services" }
            };

            List<object> ddlData = new List<object>()
            {
                new { value = "Horizontal", text = "Horizontal" },
                new { value = "Vertical", text = "Vertical" },
            };

            ViewData["data"] = data;
            ViewData["menuFields"] = menuFields;
            ViewData["ddlData"] = ddlData;
            ViewData["headerData"] = headerData;
            return View();
        }
    }
}
