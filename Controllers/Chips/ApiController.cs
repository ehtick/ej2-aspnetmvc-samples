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

namespace EJ2MVCSampleBrowser.Controllers.Chips
{
    public partial class ChipsController : Controller
    {
        public ActionResult Api()
        {

            List<object> ddlData = new List<object>();
            ddlData.Add(new { text = "Default", id = "1" });
            ddlData.Add(new { text = "Primary", id = "2" });
            ddlData.Add(new { text = "Success", id = "3" });
            ddlData.Add(new { text = "Danger", id = "4" });
            ddlData.Add(new { text = "Warning", id = "5" });
            ddlData.Add(new { text = "Info", id = "6" });

            ViewData["ddlData"] = ddlData;

            List<object> avatarData = new List<object>();
            avatarData.Add(new { text = "None", id = "1" });
            avatarData.Add(new { text = "Icon", id = "2" });
            avatarData.Add(new { text = "Image", id = "3" });
            avatarData.Add(new { text = "Letter", id = "4" });

            ViewData["avatarData"] = avatarData;

            return View();


        }
    }
}