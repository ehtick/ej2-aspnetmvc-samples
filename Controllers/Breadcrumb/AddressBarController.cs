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
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;
using Syncfusion.EJ2.Base;
using System.Web.Http;

namespace EJ2MVCSampleBrowser.Controllers.Breadcrumb
{
    public partial class BreadcrumbController : Controller
    {
        // GET: /<controller>/
        public ActionResult AddressBar()
        {
            return View();
        }

        public ActionResult AddressBarItemTemplatePartial(BreadcrumbItemModel value)
        {
            string id = value.Text != null ? value.Text.Split(' ')[0].Split('.')[0] : "Home";
            List<MenuItem> menuItems = new List<MenuItem>(){
            new MenuItem
            {
                Text = value.Text,
                IconCss = value.IconCss
            }
            };
            ViewData["menuItems"] = menuItems;
            return PartialView("_AddressBarItemTemplatePartial", id);
        }

        public ActionResult AddressBarSeparatorTemplatePartial(BreadcrumbItemModel value)
        {
            string id = value.Text != null ? value.Text.Split(' ')[0].Split('.')[0] : "Home";
            List<MenuItem> parentMenuItems = new List<MenuItem>() {
                new MenuItem { Items = new List<MenuItem>() }
            };
            List<MenuItem> subMenuItems = (List<MenuItem>)parentMenuItems[0].Items;
            var items = getItems(value.Text, false, value.Items);
            if (items != null)
            {
                foreach (var item in items)
                {
                    subMenuItems.Add(new MenuItem { Text = item.Text, Id = item.Type });
                }
            }
            ViewData["subMenuItems"] = parentMenuItems;
            return PartialView("_AddressBarSeparatorTemplatePartial", id);
        }

        private List<AddressBarItemModel> getItems(string text, bool needParent, List<BreadcrumbItemModel> breadcrumbItems)
        {
            List<AddressBarItemModel> mItems = items;
            bool isBreaked = false;
            if (text == null)
            {
                mItems = getSubMenuItems(mItems);
            }
            else
            {
                for (var i = 1; i < breadcrumbItems.Count; i++)
                {
                    for (var j = 0; j < mItems.Count; j++)
                    {
                        if (mItems[j].Text == breadcrumbItems[i].Text)
                        {
                            if (mItems[j].Text == text)
                            {
                                if (needParent)
                                {
                                    mItems = new List<AddressBarItemModel>() { mItems[j] };
                                }
                                else
                                {
                                    mItems = getSubMenuItems(mItems[j].Items);
                                }
                                isBreaked = true;
                            }
                            else
                            {
                                mItems = mItems[j].Items;
                                j = 0;
                                if (mItems == null)
                                {
                                    isBreaked = true;
                                }
                            }
                            break;
                        }
                    }
                    if (isBreaked)
                    {
                        break;
                    }
                }
            }
            return mItems;
        }

        private List<AddressBarItemModel> getSubMenuItems(List<AddressBarItemModel> mItems)
        {
            List<AddressBarItemModel> subItems = new List<AddressBarItemModel>();
            if (mItems != null)
            {
                for (var i = 0; i < mItems.Count; i++)
                {
                    subItems.Add(new AddressBarItemModel { Text = mItems[i].Text, Type = mItems[i].Type });
                }
            }
            return subItems;
        }

        private List<AddressBarItemModel> items = new List<AddressBarItemModel>() {
        new AddressBarItemModel {
            Text = "OneDrive", Type = "onedrive",
            Items = new List<AddressBarItemModel>() {
               new AddressBarItemModel { Text = "Documents", Type = "folder" },
               new AddressBarItemModel { Text = "Email attachments", Type = "folder" },
               new AddressBarItemModel { Text = "Music", Type = "folder" },
               new AddressBarItemModel { Text = "Pictures", Type = "folder" }
            }
        },
       new AddressBarItemModel {
            Text = "This PC", Type = "desktop",
            Items = new List<AddressBarItemModel>() {
               new AddressBarItemModel { Text = "Desktop", Type = "desktop" },
               new AddressBarItemModel { Text = "Documents", Type = "documents",
                   Items = new List<AddressBarItemModel>() {
                   new AddressBarItemModel { Text = "IISExpress", Type = "folder",
                       Items = new List<AddressBarItemModel>() {
                       new AddressBarItemModel { Text = "config", Type = "folder" }
                    } },
                   new AddressBarItemModel { Text = "Visual Studio 2019", Type = "folder",
                       Items = new List<AddressBarItemModel>() {
                       new AddressBarItemModel { Text = "Code Snippets", Type = "folder" },
                       new AddressBarItemModel { Text = "Templates", Type = "folder" },
                       new AddressBarItemModel { Text = "Visualizers", Type = "folder" }
                    } }
                } },
               new AddressBarItemModel { Text = "Downloads", Type = "downloads" },
               new AddressBarItemModel { Text = "Local Disk (C:)", Type = "folder",
                    Items = new List<AddressBarItemModel>() {
                       new AddressBarItemModel {
                            Text = "Microsoft", Type = "folder"
                        },
                       new AddressBarItemModel { Text = "Program Files", Type = "folder",
                           Items = new List<AddressBarItemModel>() {
                           new AddressBarItemModel { Text = "Git", Type = "folder",
                               Items = new List<AddressBarItemModel>() {
                               new AddressBarItemModel { Text = "bin", Type = "folder" },
                               new AddressBarItemModel { Text = "cmd", Type = "folder" },
                               new AddressBarItemModel { Text = "dev", Type = "folder" }
                            } },
                           new AddressBarItemModel { Text = "Google", Type = "folder",
                               Items = new List<AddressBarItemModel>() {
                               new AddressBarItemModel { Text = "Chrome", Type = "folder" }
                            } },
                           new AddressBarItemModel { Text = "Internet Explorer", Type = "folder",
                               Items = new List<AddressBarItemModel>() {
                               new AddressBarItemModel { Text = "en-US", Type = "folder" }
                            } }
                        } },
                       new AddressBarItemModel { Text = "Program Files (x86)", Type = "folder",
                           Items = new List<AddressBarItemModel>() {
                           new AddressBarItemModel { Text = "Microsoft", Type = "folder",
                               Items = new List<AddressBarItemModel>() {
                               new AddressBarItemModel { Text = "Edge", Type = "folder" }
                            } },
                           new AddressBarItemModel { Text = "MSBuild", Type = "folder" },
                           new AddressBarItemModel { Text = "Windows Defender", Type = "folder" }
                        } },
                       new AddressBarItemModel {
                            Text = "Users", Type = "folder", Items = new List<AddressBarItemModel>() {
                               new AddressBarItemModel {
                                    Text = "Admin", Type = "folder", Items = new List<AddressBarItemModel>() {
                                       new AddressBarItemModel { Text = "Desktop", Type = "desktop" },
                                       new AddressBarItemModel { Text = "Documents", Type = "documents" },
                                       new AddressBarItemModel { Text = "Downloads", Type = "downloads" },
                                       new AddressBarItemModel { Text = "Pictures", Type = "picture" }
                                    }
                                },
                               new AddressBarItemModel { Text = "Public", Type = "folder" }
                            }
                        },
                       new AddressBarItemModel { Text = "Windows", Type = "folder",
                           Items = new List<AddressBarItemModel>() {
                           new AddressBarItemModel { Text = "Boot", Type = "folder" },
                           new AddressBarItemModel { Text = "System32", Type = "folder",
                               Items = new List<AddressBarItemModel>() {
                               new AddressBarItemModel { Text = "Configuration", Type = "folder" },
                               new AddressBarItemModel { Text = "LogFiles", Type = "folder" }
                            } }
                        } }
                    }
                },
               new AddressBarItemModel { Text = "Local Disk (D:)", Type = "folder" }
            }
        },
       new AddressBarItemModel { Text = "Libraries", Type = "folder" },
       new AddressBarItemModel { Text = "Network", Type = "network" },
       new AddressBarItemModel { Text = "Recycle Bin", Type = "recyclebin" }
        };

        public class AddressBarItemModel
        {
            public string Text { get; set; }
            public string Type { get; set; }
            public List<AddressBarItemModel> Items { get; set; }
        }
    }
}
