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
using Syncfusion.EJ2.QueryBuilder;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;
using Syncfusion.EJ2.Base;

namespace EJ2MVCSampleBrowser.Controllers.QueryBuilder
{
    public partial class QueryBuilderController : Controller
    {
        public ActionResult HeaderTemplate()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="First Name", Field="FirstName", Type="string", Operator="equal", Value="Nancy"  },
                    new QueryBuilderRule { Label="Country", Field="Country", Type="string", Operator="equal", Value = "USA" }
                }
            };
            ViewData["rule"] = rule;
            return View();
        }
        public ActionResult HeaderTemplatePartial(QueryTemplateModel.ValueModel args)
        {
             List<Object> Conditions = new List<object>()
            {
                new {text = "AND", value="and" },
                new {text = "OR", value="or"}
            };
            ViewData["Conditions"] = Conditions;
            return PartialView("_HeaderTemplatePartial", args.Value);
        }
    }
}