#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields customFields = new DropDownTreeFields();
        public ActionResult CustomTemplate()
        {
            DropDownTreeCheckbox dropdDownTreeData = new DropDownTreeCheckbox();
            customFields.DataSource = dropdDownTreeData.Checkbox();
            customFields.Value = "id";
            customFields.Text = "name";
            customFields.Expanded = "expanded";
            customFields.HasChildren = "hasChild";
            customFields.ParentValue = "pid";
            ViewData["CustomFields"] = customFields;
            DropDownTreeTreeSettings treeSettings = new DropDownTreeTreeSettings();
            treeSettings.AutoCheck = true;
            ViewData["TreeSettings"] = treeSettings;
            return View();
        }
    }
}