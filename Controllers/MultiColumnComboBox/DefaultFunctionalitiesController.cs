#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.MultiColumnComboBox
{
    public partial class MultiColumnComboBoxController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            var model = new OrderDetailsViewModel
            {
                OrderDetails = GetOrderDetails()
            };
            return View(model);
        }

        private List<OrderList> GetOrderDetails()
        {
            return new List<OrderList>
            {
                new OrderList { OrderID = 1001, CustomerID = "CID01", Role = "Admin", EmployeeID = 5, OrderDate = "1995-07-04T00:00:00.000Z", ShipName = "Vins et alcools Chevalier", ShipCity = "Reims", ShipAddress = "59 rue de l Abbaye", ShipRegion = "CJ", Mask = "1111", ShipPostalCode = "51100", ShipCountry = "France", Freight = 32.38, Verified = true, CustomerName = "John" },
                new OrderList { OrderID = 1002, CustomerID = "CID02", Role = "Employee", EmployeeID = 6, OrderDate = "1995-07-05T00:00:00.000Z", ShipName = "Toms Spezialitäten", ShipCity = "Münster", ShipAddress = "Luisenstr. 48", ShipRegion = "CJ", Mask = "2222", ShipPostalCode = "44087", ShipCountry = "Germany", Freight = 11.61, Verified = false, CustomerName = "Alice" },
                new OrderList { OrderID = 1003, CustomerID = "CID03", Role = "Admin", EmployeeID = 4, OrderDate = "1995-07-08T00:00:00.000Z", ShipName = "Hanari Carnes", ShipCity = "Rio de Janeiro", ShipAddress = "Rua do Paço, 67", ShipRegion = "RJ", Mask = "3333", ShipPostalCode = "05454-876", ShipCountry = "Brazil", Freight = 65.83, Verified = true, CustomerName = "Bob" },
                new OrderList { OrderID = 1004, CustomerID = "CID04", Role = "Manager", EmployeeID = 3, OrderDate = "1995-07-08T00:00:00.000Z", ShipName = "Victuailles en stock", ShipCity = "Lyon", ShipAddress = "2, rue du Commerce", ShipRegion = "CJ", Mask = "4444", ShipPostalCode = "69004", ShipCountry = "Argentina", Freight = 41.34, Verified = true, CustomerName = "Mario Pontes" },
                new OrderList { OrderID = 1005, CustomerID = "CID05", Role = "Manager", EmployeeID = 2, OrderDate = "1995-07-09T00:00:00.000Z", ShipName = "Suprêmes délices", ShipCity = "Charleroi", ShipAddress = "Boulevard Tirou, 255", ShipRegion = "CJ", Mask = "5555", ShipPostalCode = "B-6000", ShipCountry = "Belgium", Freight = 51.3, Verified = true, CustomerName = "Yang Wang" },
                new OrderList { OrderID = 1006, CustomerID = "CID06", Role = "Admin", EmployeeID = 7, OrderDate = "1995-07-10T00:00:00.000Z", ShipName = "Hanari Carnes", ShipCity = "Rio de Janeiro", ShipAddress = "Rua do Paço, 67", ShipRegion = "RJ", Mask = "6666", ShipPostalCode = "05454-876", ShipCountry = "Armenia", Freight = 58.17, Verified = true, CustomerName = "Michael" },
                new OrderList { OrderID = 1007, CustomerID = "CID07", Role = "Employee", EmployeeID = 5, OrderDate = "1995-07-11T00:00:00.000Z", ShipName = "Chop-suey Chinese", ShipCity = "Bern", ShipAddress = "Hauptstr. 31", ShipRegion = "CJ", Mask = "7777", ShipPostalCode = "3012", ShipCountry = "Switzerland", Freight = 22.98, Verified = false, CustomerName = "Nancy" },
                new OrderList { OrderID = 1008, CustomerID = "CID08", Role = "Admin", EmployeeID = 9, OrderDate = "1995-07-12T00:00:00.000Z", ShipName = "Richter Supermarkt", ShipCity = "Genève", ShipAddress = "Starenweg 5", ShipRegion = "CJ", Mask = "8888", ShipPostalCode = "1204", ShipCountry = "Antarctica", Freight = 148.33, Verified = true, CustomerName = "Robert King" },
                new OrderList { OrderID = 1009, CustomerID = "CID09", Role = "Employee", EmployeeID = 3, OrderDate = "1995-07-15T00:00:00.000Z", ShipName = "Wellington Importadora", ShipCity = "Resende", ShipAddress = "Rua do Mercado, 12", ShipRegion = "SP", Mask = "9999", ShipPostalCode = "08737-363", ShipCountry = "Albania", Freight = 13.97, Verified = false, CustomerName = "Andrew Fuller" },
                new OrderList { OrderID = 1010, CustomerID = "CID10", Role = "Admin", EmployeeID = 4, OrderDate = "1995-07-16T00:00:00.000Z", ShipName = "HILARION-Abastos", ShipCity = "San Cristóbal", ShipAddress = "Carrera 22 con Ave. Carlos Soublette #8-35", ShipRegion = "Táchira", Mask = "1234", ShipPostalCode = "5022", ShipCountry = "Venezuela", Freight = 81.91, Verified = true, CustomerName = "Anne Dodsworth" },
                new OrderList { OrderID = 1011, CustomerID = "CID11", Role = "Manager", EmployeeID = 1, OrderDate = "1995-07-17T00:00:00.000Z", ShipName = "Ernst Handel", ShipCity = "Graz", ShipAddress = "Kirchgasse 6", ShipRegion = "CJ", Mask = "2345", ShipPostalCode = "8010", ShipCountry = "Austria", Freight = 140.51, Verified = true, CustomerName = "Janet Leverling" },
                new OrderList { OrderID = 1012, CustomerID = "CID12", Role = "Admin", EmployeeID = 4, OrderDate = "1995-07-18T00:00:00.000Z", ShipName = "Centro comercial Moctezuma", ShipCity = "México D.F.", ShipAddress = "Sierras de Granada 9993", ShipRegion = "CJ", Mask = "3456", ShipPostalCode = "05022", ShipCountry = "Mexico", Freight = 3.25, Verified = false, CustomerName = "Laura Callahan" },
                new OrderList { OrderID = 1013, CustomerID = "CID13", Role = "Admin", EmployeeID = 4, OrderDate = "1995-07-19T00:00:00.000Z", ShipName = "Ottilies Käseladen", ShipCity = "Köln", ShipAddress = "Mehrheimerstr. 369", ShipRegion = "CJ", Mask = "4567", ShipPostalCode = "50739", ShipCountry = "Belgium", Freight = 55.09, Verified = true, CustomerName = "Margaret Peacock" },
                new OrderList { OrderID = 1014, CustomerID = "CID14", Role = "Manager", EmployeeID = 4, OrderDate = "1995-07-19T00:00:00.000Z", ShipName = "Que Delícia", ShipCity = "Rio de Janeiro", ShipAddress = "Rua da Panificadora, 12", ShipRegion = "RJ", Mask = "5678", ShipPostalCode = "02389-673", ShipCountry = "Cuba", Freight = 3.05, Verified = false, CustomerName = "Michael Suyama" },
                new OrderList { OrderID = 1015, CustomerID = "CID15", Role = "Employee", EmployeeID = 8, OrderDate = "1995-07-22T00:00:00.000Z", ShipName = "Rattlesnake Canyon Grocery", ShipCity = "Albuquerque", ShipAddress = "2817 Milton Dr.", ShipRegion = "NM", Mask = "6789", ShipPostalCode = "87110", ShipCountry = "USA", Freight = 48.29, Verified = true, CustomerName = "Nancy Davolio" },
                new OrderList { OrderID = 1016, CustomerID = "CID16", Role = "Employee", EmployeeID = 6, OrderDate = "1995-07-24T00:00:00.000Z", ShipName = "Blondel père et fils", ShipCity = "Strasbourg", ShipAddress = "24, place Kléber", ShipRegion = "CJ", Mask = "8901", ShipPostalCode = "67000", ShipCountry = "Albania", Freight = 81.74, Verified = false, CustomerName = "Robert King" },
                new OrderList { OrderID = 1017, CustomerID = "CID17", Role = "Manager", EmployeeID = 3, OrderDate = "1995-07-25T00:00:00.000Z", ShipName = "Wartian Herkku", ShipCity = "Oulu", ShipAddress = "Torikatu 38", ShipRegion = "CJ", Mask = "9012", ShipPostalCode = "90110", ShipCountry = "Finland", Freight = 44.12, Verified = true, CustomerName = "Steven Buchanan" },
                new OrderList { OrderID = 1018, CustomerID = "CID18", Role = "Admin", EmployeeID = 1, OrderDate = "1995-07-26T00:00:00.000Z", ShipName = "FISSA Fabrica Inter. Salchichas S.A.", ShipCity = "Madrid", ShipAddress = "C/ Moralzarzal, 86", ShipRegion = "CJ", Mask = "0123", ShipPostalCode = "28034", ShipCountry = "Portugal", Freight = 231.73, Verified = false, CustomerName = "John Doe" },
                new OrderList { OrderID = 1019, CustomerID = "CID19", Role = "Manager", EmployeeID = 6, OrderDate = "1995-07-27T00:00:00.000Z", ShipName = "The Big Cheese", ShipCity = "Portland", ShipAddress = "89 Jefferson Way Suite 2", ShipRegion = "OR", Mask = "1234", ShipPostalCode = "97201", ShipCountry = "USA", Freight = 22.63, Verified = false, CustomerName = "Jane Smith" },
                new OrderList { OrderID = 1020, CustomerID = "CID20", Role = "Manager", EmployeeID = 2, OrderDate = "1995-07-28T00:00:00.000Z", ShipName = "Galería del gastronómo", ShipCity = "Madrid", ShipAddress = "Rambla de Cataluña, 23", ShipRegion = "CJ", Mask = "2345", ShipPostalCode = "28014", ShipCountry = "Spain", Freight = 89.64, Verified = false, CustomerName = "James Brown" }
            };
        }

        public class OrderDetailsViewModel
        {
            public List<OrderList> OrderDetails { get; set; }
        }

        public class OrderList
        {
            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public string Role { get; set; }
            public int EmployeeID { get; set; }
            public string OrderDate { get; set; }
            public string ShipName { get; set; }
            public string ShipCity { get; set; }
            public string ShipAddress { get; set; }
            public string ShipRegion { get; set; }
            public string Mask { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipCountry { get; set; }
            public double Freight { get; set; }
            public bool Verified { get; set; }
            public string CustomerName { get; set; }
        }
    }
}