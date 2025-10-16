#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Base;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        public static List<DynamicList> DynamicOrders { get; set; } = new List<DynamicList>();

        // GET: DynamicObjectBinding
        public ActionResult DynamicObjectBinding()
        {
            string[] customerIDs = { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" };
            string[] shipCountrys = { "USA", "UK", "Denmark", "Australia", "India" };
            DynamicOrders = Enumerable.Range(1, 75).Select((x) =>
            {
                dynamic d = new DynamicList();
                d.OrderID = 1000 + x;
                d.CustomerID = customerIDs[x % customerIDs.Length];
                d.Freight = (new double[] { 2, 1, 4, 5, 3 })[new Random().Next(5)] * x;
                d.OrderDate = (new DateTime[] { new DateTime(2010, 11, 5), new DateTime(2018, 10, 3), new DateTime(1995, 9, 9), new DateTime(2012, 8, 2), new DateTime(2015, 4, 11) })[new Random().Next(5)];
                d.ShipCountry = shipCountrys[x % shipCountrys.Length];
                return d;
            }).Cast<DynamicList>().ToList<DynamicList>();
            ViewData["DynamicData"] = DynamicOrders;
            return View();
        }

        public class DynamicList : DynamicObject
        {
            private List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();

            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                string name = binder.Name;
                var property = properties.Find(p => p.Key == name);
                result = property.Value;
                return property.Key != null;
            }

            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                string name = binder.Name;
                var property = properties.Find(p => p.Key == name);
                if (property.Key != null)
                {
                    properties.Remove(property);
                }

                properties.Add(new KeyValuePair<string, object>(name, value));
                return true;
            }


            public override IEnumerable<string> GetDynamicMemberNames()
            {
                return properties.ConvertAll(p => p.Key);
            }
        }
    }
}