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
using Syncfusion.EJ2.Diagrams;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public  partial class DiagramController : Controller
    {
        // GET: PrintandExport
        public ActionResult PrintandExport()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Source Document", Margin = new DiagramMargin() { Left = 15, Right = 15, Bottom = 15, Top = 15 } });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Census Record", Margin = new DiagramMargin() { Left = 15, Right = 15, Bottom = 15, Top = 15 } });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Books and Magazine" });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Record Template" });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "Traditional Template" });
            List<DiagramNodeAnnotation> Node6 = new List<DiagramNodeAnnotation>();
            Node6.Add(new DiagramNodeAnnotation() { Content = "Non Traditional" });
            List<DiagramNodeAnnotation> Node7 = new List<DiagramNodeAnnotation>();
            Node7.Add(new DiagramNodeAnnotation() { Content = "Health Fitness" });
            List<DiagramNodeAnnotation> Node8 = new List<DiagramNodeAnnotation>();
            Node8.Add(new DiagramNodeAnnotation() { Content = "Diet" });
            List<DiagramNodeAnnotation> Node9 = new List<DiagramNodeAnnotation>();
            Node9.Add(new DiagramNodeAnnotation() { Content = "Flexibility" });
            List<DiagramNodeAnnotation> Node10 = new List<DiagramNodeAnnotation>();
            Node10.Add(new DiagramNodeAnnotation() { Content = "Muscular Endurance" });
            List<DiagramNodeAnnotation> Node11 = new List<DiagramNodeAnnotation>();
            Node11.Add(new DiagramNodeAnnotation() { Content = "Cardiovascular Strength" });
            List<DiagramNodeAnnotation> Node12 = new List<DiagramNodeAnnotation>();
            Node12.Add(new DiagramNodeAnnotation() { Content = "Muscular Strength" });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "sourceNode1",
                OffsetX = 120,
                OffsetY = 100,
                Width = 100,
                Height = 50,
                Annotations = Node1,
                Style = new DiagramShapeStyle() { StrokeColor = "#868686", Fill = "#d5f5d5" }
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "censusNode2",
                OffsetX = 120,
                OffsetY = 200,
                Width = 100,
                Height = 75,
                Annotations = Node2,
                Style = new DiagramShapeStyle() { StrokeColor = "#8f908f", Fill = "#e2f3fa" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Diamond }
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "booksNode3",
                OffsetX = 120,
                OffsetY = 325,
                Width = 100,
                Height = 75,
                Annotations = Node3,
                Style = new DiagramShapeStyle() { StrokeColor = "#8f908f", Fill = "#e2f3fa" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Diamond }
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "recordNode4",
                OffsetX = 320,
                OffsetY = 200,
                Width = 125,
                Height = 50,
                Annotations = Node4,
                Style = new DiagramShapeStyle() { StrokeColor = "#868686", Fill = "#d5f5d5" }
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "traditionalNode5",
                OffsetX = 320,
                OffsetY = 325,
                Width = 125,
                Height = 50,
                Annotations = Node5,
                Style = new DiagramShapeStyle() { StrokeColor = "#868686", Fill = "#d5f5d5" }
            });
            nodes.Add(new Syncfusion.EJ2.Diagrams.DiagramNode()
            {
                Id = "nontraditionalNode6",
                OffsetX = 120,
                OffsetY = 425,
                Width = 135,
                Height = 50,
                Annotations = Node6,
                Style = new DiagramShapeStyle() { StrokeColor = "#a8a8a8", Fill = "#faebee" }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Radial1",
                OffsetX = 850,
                OffsetY = 225,
                Annotations = Node7,
                Width = 100,
                Height = 75,
                Style = new DiagramShapeStyle() { StrokeColor = "#a8a8a8", Fill = "#fef0db" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Radial3",
                OffsetX = 1025,
                OffsetY = 175,
                Annotations = Node9,
                Width = 100,
                Height = 75,
                Style = new DiagramShapeStyle() { StrokeColor = "#a8a8a8", Fill = "#faebee" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Radial4",
                OffsetX = 1000,
                OffsetY = 350,
                Annotations = Node10,
                Width = 100,
                Height = 75,
                Style = new DiagramShapeStyle() { StrokeColor = "#a8a8a8", Fill = "#faebee" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Radial5",
                OffsetX = 675,
                OffsetY = 175,
                Annotations = Node11,
                Width = 100,
                Height = 75,
                Style = new DiagramShapeStyle() { StrokeColor = "#a8a8a8", Fill = "#faebee" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Radial6",
                OffsetX = 770,
                OffsetY = 350,
                Width = 100,
                Height = 75,
                Annotations = Node12,
                Style = new DiagramShapeStyle() { StrokeColor = "#a8a8a8", Fill = "#faebee" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }
            });
            nodes.Add(new DiagramNode()
            {
                Id = "Radial2",
                OffsetX = 850,
                OffsetY = 100,
                Width = 100,
                Height = 75,
                Annotations = Node8,
                Style = new DiagramShapeStyle() { StrokeColor = "#a8a8a8", Fill = "#faebee" },
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }
            });

            List<DiagramConnectorAnnotation> flowconnector2 = new List<DiagramConnectorAnnotation>();
            flowconnector2.Add(new DiagramConnectorAnnotation() { Content = "No" });
            List<DiagramConnectorAnnotation> flowconnector3 = new List<DiagramConnectorAnnotation>();
            flowconnector3.Add(new DiagramConnectorAnnotation() { Content = "No" });
            List<DiagramConnectorAnnotation> flowconnector4 = new List<DiagramConnectorAnnotation>();
            flowconnector4.Add(new DiagramConnectorAnnotation() { Content = "Yes" });
            List<DiagramConnectorAnnotation> flowconnector5 = new List<DiagramConnectorAnnotation>();
            flowconnector5.Add(new DiagramConnectorAnnotation() { Content = "Yes" });

            List<DiagramConnectorAnnotation> radialConnector1 = new List<DiagramConnectorAnnotation>();
            radialConnector1.Add(new DiagramConnectorAnnotation() { Content = "Yes" });
            List<DiagramConnectorAnnotation> radialConnector2 = new List<DiagramConnectorAnnotation>();
            radialConnector2.Add(new DiagramConnectorAnnotation() { Content = "Yes" });
            List<DiagramConnectorAnnotation> radialConnector3 = new List<DiagramConnectorAnnotation>();
            radialConnector3.Add(new DiagramConnectorAnnotation() { Content = "Yes" });
            List<DiagramConnectorAnnotation> radialConnector4 = new List<DiagramConnectorAnnotation>();
            radialConnector4.Add(new DiagramConnectorAnnotation() { Content = "Yes" });
            List<DiagramConnectorAnnotation> radialConnector5 = new List<DiagramConnectorAnnotation>();
            radialConnector5.Add(new DiagramConnectorAnnotation() { Content = "Yes" });

            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector() { Id = "flowChartConnector1", SourceID = "sourceNode1", TargetID = "censusNode2" });
            connectors.Add(new DiagramConnector() { Id = "flowChartConnector2", SourceID = "censusNode2", TargetID = "booksNode3", Annotations = flowconnector2 });
            connectors.Add(new DiagramConnector() { Id = "flowChartConnector3", SourceID = "booksNode3", TargetID = "nontraditionalNode6", Annotations = flowconnector3 });
            connectors.Add(new DiagramConnector() { Id = "flowChartConnector4", SourceID = "censusNode2", TargetID = "recordNode4", Annotations = flowconnector4 });
            connectors.Add(new DiagramConnector() { Id = "flowChartConnector5", SourceID = "booksNode3", TargetID = "traditionalNode5", Annotations = flowconnector5 });
            connectors.Add(new DiagramConnector() { Id = "RadialConnector1", SourceID = "Radial1", TargetID = "Radial2", Annotations = radialConnector1 });
            connectors.Add(new DiagramConnector() { Id = "RadialConnector2", SourceID = "Radial1", TargetID = "Radial3", Annotations = radialConnector2 });
            connectors.Add(new DiagramConnector() { Id = "RadialConnector3", SourceID = "Radial1", TargetID = "Radial4", Annotations = radialConnector3 });
            connectors.Add(new DiagramConnector() { Id = "RadialConnector4", SourceID = "Radial1", TargetID = "Radial5", Annotations = radialConnector4 });
            connectors.Add(new DiagramConnector() { Id = "RadialConnector5", SourceID = "Radial1", TargetID = "Radial6", Annotations = radialConnector5 });
            ViewData["nodes"] = nodes;
            ViewData["connectors"] = connectors;
            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { Template = "#exportBtn", Type = ItemType.Input, TooltipText = "Export Diagram",Text="Export" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-print", Text = "Print", TooltipText = "Print Diagram" });
                items.Add(new ToolbarItem { Template = "#multiplePageCb", Type = ItemType.Input, TooltipText = "Multiple Page",});

            }
            ViewData["tbItems"] = items;
            List<MenuItems> exportItems = new List<MenuItems>();
            {
                exportItems.Add(new MenuItems { Text = "JPG" });
                exportItems.Add(new MenuItems { Text = "PNG" });
                exportItems.Add(new MenuItems { Text = "SVG" });
            }
            ViewData["exportItems"] = exportItems;
            return View();
        }
    }

}