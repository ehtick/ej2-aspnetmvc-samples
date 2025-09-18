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
        // GET: Hamburger
        public ActionResult Hamburger()
        {
            List<MenuItem> menuItems = new List<MenuItem>(){
            new MenuItem
            {
                Text = "Accessories",
                Items = new List<MenuItem>()
                {
                    new MenuItem {
                        Text = "Mobile",
                        Items = new List<MenuItem>()
                        {
                            new MenuItem { Text= "Headphones" },
                            new MenuItem { Text= "Batteries" },
                            new MenuItem { Text= "Memory Cards" }
                        }
                    },
                    new MenuItem { Text = "Laptops" },
                    new MenuItem {
                        Text = "Desktop PC",
                        Items = new List<MenuItem>()
                        {
                            new MenuItem { Text= "Pendrives" },
                            new MenuItem { Text= "External Hard Disks" }
                        }
                    },
                    new MenuItem {
                        Text = "Camera",
                        Items = new List<MenuItem>()
                        {
                            new MenuItem { Text= "Lens" },
                            new MenuItem { Text= "Tripods" }
                        }
                    }
                }
            },
            new MenuItem
            {
                Text = "Fashion",
                Items = new List<MenuItem>()
                {
                    new MenuItem { Text= "Men" },
                    new MenuItem { Text= "Women" }
                }
            },
            new MenuItem
            {
                Text = "Home & Living",
                Items = new List<MenuItem>()
                {
                    new MenuItem { Text= "Furniture" },
                    new MenuItem { Text= "Decor" },
                    new MenuItem { Text= "Smart Home Automation" },
                    new MenuItem { Text= "Dining & Serving" }
                }
            },
            new MenuItem
            {
                Text = "Entertainment",
                Items = new List<MenuItem>()
                {
                    new MenuItem { Text= "Televisions" },
                    new MenuItem { Text= "Home Theatres" },
                    new MenuItem { Text= "Gaming Laptops" }
                }
            },
            new MenuItem { Text = "Contact Us" },
            new MenuItem { Text = "Help" }
            };

            List<object> ddlData = new List<object>()
            {
                new { value = "Mobile", text = "Mobile" },
                new { value = "Tablet", text = "Tablet" },
                new { value = "Desktop", text = "Desktop" }
            };

            ViewData["data"] = menuItems;
            ViewData["ddlData"] = ddlData;
            return View();
        }
    }
}