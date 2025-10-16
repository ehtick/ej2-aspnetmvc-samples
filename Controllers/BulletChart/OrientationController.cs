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
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.BulletChart
{
    public partial class BulletChartController : Controller
    {
        // GET: Orientation
        public ActionResult Orientation()
        {
            List<OrientationBulletData> bulletData1 = new List<OrientationBulletData>
            {
                new OrientationBulletData { value = 270, target = 250}     
            };
            ViewData["dataSource"] = bulletData1;
            return View();
        }
        public class OrientationBulletData
        {           
            public double value;
            public double target;
        }
    }
}