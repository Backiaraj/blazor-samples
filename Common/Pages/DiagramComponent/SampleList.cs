#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> DiagramComponent { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Flow Chart",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/flowchart",
                FileName = "FlowChart.razor",
                HeaderText="Flow Chart using Blazor Diagram Component Example"
            },
            new Sample
            {
                Name = "Nodes",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/nodes",
                FileName = "Nodes.razor",
                HeaderText="Example of Nodes in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Shapes",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/shapes",
                FileName = "Shapes.razor",
                HeaderText="Example of Shapes in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Node Template",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/nodetemplate",
                FileName = "NodeTemplateSample.razor",
                HeaderText="Example of NodeTemplate in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Connectors",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/connectors",
                FileName = "ConnectorSample.razor",
                HeaderText="Example of Connectors in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/annotations",
                FileName = "Annotations.razor",
                HeaderText="Example of Annotations in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Ports",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/ports",
                FileName = "Ports.razor",
                HeaderText="Example of Ports in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Events",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/events",
                FileName = "Events.razor",
                HeaderText="Example of Events in Blazor Diagram Component",
            },
            new Sample
            {
                 Name = "Constraints",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/constraints",
                FileName = "Constraintssample.razor",
                HeaderText="Example of Constraints in Blazor Diagram Component"
            },
              new Sample
            {
                Name = "Symbol Palette",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/symbolpalette",
                FileName = "SymbolPalette.razor",
                HeaderText="Example of Symbol Palette in Blazor Diagram Component",
            },
              new Sample
            {
                Name = "Z-Order",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/zorder",
                FileName = "ZOrder.razor",
                HeaderText="Example of ZOrder Commands in Blazor Diagram Component",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo to explore BringForward, SendBackward, BringToFront and SendToBack features of diagram component."
                },
            },
                new Sample
            {
                Name = "Zooming and Panning",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/zooming-panning",
                FileName = "ZoomingPanning.razor",
                Type=SampleType.Updated,
                HeaderText="Example of Zooming and Panning in Blazor Diagram Component",
                 NotificationDescription= new string[] { @"updated a demo with reset option, we can reset the zoom and scroller offsets to default values " }
            },
             new Sample
            {
                Name = "Drawing Tools",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/drawingtool",
                FileName = "DrawingToolSample.razor",
                HeaderText="Example of DrawingTools in Blazor Diagram Component"
            },
             new Sample
            {
                Name = "User Handles",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/userhandles",
                FileName = "UserHandles.razor",
                HeaderText="Example of User Handles in Blazor Diagram Component",
            },
              new Sample
            {
                Name = "Expand and Collapse",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/expandcollapse",
                Type=SampleType.New,
                FileName = "ExpandAndCollapse.razor",
                HeaderText="Example of Expand And Collapse in Blazor Diagram Component",
                NotificationDescription= new string[] { @"Added a demo to explore expand and collpase icon features of diagram component." }
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                HeaderText="Example of Keyboard Interaction in Blazor Diagram Component",
            },                       
            new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/organization-model",
                FileName = "OrganizationModel.razor",
                HeaderText="Organization Chart Example using Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Mindmap Layout",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/mindmap",
                FileName = "Mindmap.razor",
                HeaderText="Example of Mind Map Layout in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/hierarchical-tree",
                FileName = "HierarchicalTree.razor",
                HeaderText="Hierarchical Tree Example using Blazor Diagram Component",
            },
             new Sample
            {
                Name = "Complex Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/complexhierarchical",
                Type=SampleType.New,
                FileName = "ComplexHierarchicalTree.razor",
                HeaderText="ComplexHierarchical Tree Example using Blazor Diagram Component",
                NotificationDescription= new string[] { @"Added a demo to explore complex hierarchical tree features of diagram component." }
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/local-data",
                FileName = "LocalData.razor",
                HeaderText="Example of Local Data in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/remote-data",
                FileName = "RemoteData.razor",
                HeaderText="Example of Remote Data in Blazor Diagram Component"
            },
            new Sample
            {
               Name = "Serialization",
               Category = "Save and Restore",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/serialization",
                FileName = "Serialization.razor",
               HeaderText="Example of Serialization in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Export",
                Category = "Export and Print",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/export",
                FileName = "ExportSample.razor",
                HeaderText="Example of Exporting in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Print",
                Category = "Export and Print",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/print",
                FileName = "PrintSample.razor",
                HeaderText="Example of Printing in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Venn Diagram",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/venn-diagram",
                FileName = "VennDiagram.razor",
                HeaderText="Example of Venn Diagram in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/fishbone-diagram",
                FileName = "FishboneDiagram.razor",
                HeaderText="Example of Fishbone Diagram in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Flow Execution",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/flow-execution",
                FileName = "FlowExecution.razor",
                HeaderText="Example of Flow Execution in Blazor Diagram Component"
            },                                   
        };
    }
}
