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

namespace EJ2MVCSampleBrowser.Models
{
    public class Employees
    {
        public string Name { get; set; }
        public string Eimg { get; set; }
        public string Designation { get; set; }
        public string Country { get; set; }
        public List<Employees> EmployeesList()
        {
            List<Employees> emp = new List<Models.Employees>();
            emp.Add(new Employees { Name= "Andrew Fuller", Eimg= "7", Designation = "Team Lead", Country= "England"});
            emp.Add(new Employees { Name= "Anne Dodsworth", Eimg= "1", Designation = "Developer", Country= "USA"});
            emp.Add(new Employees { Name= "Janet Leverling", Eimg= "3", Designation = "HR", Country= "USA"});
            emp.Add(new Employees { Name= "Laura Callahan", Eimg= "2", Designation = "Product Manager", Country= "USA"});
            emp.Add(new Employees { Name= "Margaret Peacock", Eimg= "6", Designation = "Developer", Country= "USA"});
            emp.Add(new Employees { Name= "Michael Suyama", Eimg= "9", Designation = "Team Lead", Country= "USA"});
            emp.Add(new Employees { Name= "Nancy Davolio", Eimg= "4", Designation = "Product Manager", Country= "USA"});
            emp.Add(new Employees { Name= "Robert King", Eimg= "8", Designation = "Developer ", Country= "England"});
            emp.Add(new Employees { Name= "Steven Buchanan", Eimg= "10", Designation = "CEO", Country= "England" });
            return emp;
        }
    }
}
