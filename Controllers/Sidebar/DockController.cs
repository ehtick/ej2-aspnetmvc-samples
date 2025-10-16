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

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SidebarController : Controller
    {
        // GET: Dock
        public ActionResult Dock()
        {
            List<ToolbarItem> popItems = new List<ToolbarItem>();
            var folderTemplate = "<div class='e-folder'><div class='e-folder-name'>ASP.NET MVC Documentation</div></div>";
            popItems.Add(new ToolbarItem { PrefixIcon = "e-tbar-menu-icon tb-icons", TooltipText = "Menu" });
            popItems.Add(new ToolbarItem { Template = folderTemplate });
            Dictionary<string, object> HtmlAttribute = new Dictionary<string, object>()
            {   {"class", "dockSidebar" } };
            List<ListViewData> List = new List<ListViewData>
            {
                new ListViewData {Id="1", Text = "Grid", IconCss = "sb-icons icon-grid e-sb-icon control-icon", Description = "The ASP.NET MVC DataGrid is a feature-rich component useful for displaying data in a tabular format. Its wide range of functionalities includes data binding, editing, Excel-like filtering, custom sorting, aggregating rows, selection, and support for Excel, CSV, and PDF formats. It loads millions of records in just a second. It has flexible editing and intuitive record selection modes. Also, it has seamless data exporting options like PDF, CSV, and Excel." },
                new ListViewData {Id="2",Text = "Chart", IconCss = "sb-icons icon-chart e-sb-icon control-icon", Description = "The ASP.NET MVC Charts is a well-crafted charting component to visualize data. It contains a rich UI gallery of 30+ charts and graphs, ranging from line to financial that cater to all charting scenarios. Its high performance helps to render large amounts of data quickly. It also comes with features such as zooming, panning, tooltip, crosshair, trackball, highlight, and selection." },
                new ListViewData {Id="3",Text = "Datepicker", IconCss = "sb-icons icon-datepicker e-sb-icon control-icon", Description = "The ASP.NET MVC DatePicker is a lightweight and mobile-friendly component that allows end-users to enter or select a date value. It has month, year, and decade view options to quickly navigate to the desired date. It supports minimum dates, maximum dates, and disabled dates to restrict the date selection. It has built-in features such as validation, custom date formats, range restriction, and disable dates to enhance the progressive usage." },
                new ListViewData {Id="4", Text = "Dialog", IconCss = "sb-icons icon-dialog e-sb-icon control-icon", Description = "The ASP.NET MVC Dialog is a useful user interface (UI) component for informing users about critical information, errors, warnings, and questions, as well as confirming decisions and collecting input from users. The component has a rich set of built-in features such as action buttons, positioning, animations, dragging, resizing, templating, and more with mobile dialog support. The ASP.NET MVC dialog provides two different types: modal dialogs and non-modal dialogs (modeless) based on interactions." },
                new ListViewData {Id="5", Text = "Dropdown List", IconCss = "sb-icons icon-dropdownlist e-sb-icon control-icon", Description = "The ASP.NET MVC Dropdown List is a quick replacement of the HTML select tags. It has a rich appearance and allows users to select a single value that is non-editable from a list of predefined values. It has several out-of-the-box features, such as data binding, filtering, grouping, UI customization, accessibility, and preselected values." }
            };
            ViewData["ListData"] = List;
            ViewData["DockToolItems"] = popItems;
            ViewData["HtmlAttribute"] = HtmlAttribute;
            return View();
        }
        public class ListViewData
        {
            public string Id { get; set; }
            public string Text { get; set; }
            public string IconCss { get; set; }
            public string Description { get; set; }
        }
    }
}