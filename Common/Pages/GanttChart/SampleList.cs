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

        public List<Sample> GanttChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/default-functionalities",
                MetaTitle = "Blazor Gantt Chart Example | Default Functionalities | Syncfusion Demos",
                HeaderText = "Blazor Gantt Chart Example - Default Functionalities",
                MetaDescription = "This example demonstrates the default functionalities in the Blazor Gantt Chart Component. Explore here for more details.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Editing",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/editing",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
                {
                    @"The sample has been updated to include tooltip support for taskbar editing, touch interactions for taskbar and auto scrolling support when dragging taskbar or drawing predecessor connector lines."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditData",
                        FileName="GanttData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Sorting",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/sorting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/filtering",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "Filtering.razor",
                    },
                    new SourceCollection
                    {
                        Id="Filter",
                        FileName="FilterData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Selection",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/selection",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionRecord",
                        FileName="SelectionData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/context-menu",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName = "ContextMenu.razor",
                    },
                    new SourceCollection
                    {
                        Id="ContextMenuData",
                        FileName="GanttData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Resource Allocation",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/resource-allocation",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="Resourceallocation.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResourceRecord",
                        FileName="ResourceData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Exporting",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/exporting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExportTask",
                        FileName = "Exporting.razor",
                    },
                    new SourceCollection
                    {
                        Id="ExportRecord",
                        FileName="GanttData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/keyboard-navigation",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Keyboard",
                        FileName="KeyboardNavigation.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/dynamic-data",
                FileName="DynamicData.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/expando-data",
                FileName="ExpandoData.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/remote-data",
                FileName="RemoteData.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/observable-collection",
                FileName="ObservableBinding.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo for displaying Observable collection support in Gantt chart."
                },
            },
            new Sample
            {
                Name = "Baseline",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/baseline",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Baseline",
                        FileName="Baseline.razor"
                    },
                    new SourceCollection
                    {
                        Id="BaseRecord",
                        FileName="BaseData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Event Markers",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/eventmarkers",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Events",
                        FileName="EventMarkers.razor"
                    },
                    new SourceCollection
                    {
                        Id="EventRecord",
                        FileName="EventData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Holidays",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/holidays",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Holidays",
                        FileName="Holidays.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Scheduling Mode",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/scheduling-mode",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Schedulingmode.razor"
                    },
                    new SourceCollection
                    {
                        Id="ScheduleRecord",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Unscheduled Task",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/unscheduled-task",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Unscheduled",
                        FileName = "UnscheduledTask.razor",
                    },
                    new SourceCollection
                    {
                        Id="UnscheduledData",
                        FileName="UnscheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Work Time Range",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/working-time-range",
                FileName="WorkTimeRange.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Work Week",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/work-week",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="WorkWeek.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResourceRecord",
                        FileName="WorkData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timeline",
                Category = "Timeline",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/timeline",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "Timeline.razor",
                    },
                    new SourceCollection
                    {
                        Id="TimeRecord",
                        FileName="TimelineData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Zooming",
                Category = "Timeline",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/zooming",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Zoom",
                        FileName = "Zooming.razor",
                    },
                    new SourceCollection
                    {
                        Id="ZoomRecord",
                        FileName="ZoomingData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Column",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-menu",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Column",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-reordering",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnReordering",
                        FileName="ColumnReordering.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Resizing",
                Category = "Column",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-resizing",
                FileName="ColumnResizing.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Column",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-template",
                FileName="ColumnTemplate.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Virtual Scroll",
                Category = "Scrolling",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/virtual-scroll",
                FileName="VirtualScroll.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
                {
                    @"The sample has been updated to include column virtualization support."
                },
            },
            new Sample
            {
                Name = "Row Drag and Drop",
                Category = "Row",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/row-drag-and-drop",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowDragAndDrop",
                        FileName="RowDragAndDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Height",
                Category = "Row",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/row-height",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHeight",
                        FileName="RowHeight.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },            
            new Sample
            {
                Name = "Taskbar Template",
                Category = "Customization",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/taskbar-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TaskbarTemplate",
                        FileName="GanttTaskbarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="TaskbarTemplateData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Header Template",
                Category = "Customization",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/header-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HeaderTemplate",
                        FileName="GanttHeaderTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Customization",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/tooltip-template",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
                {
                    @"This sample has been updated with editing tooltip template support."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TooltipTemplate",
                        FileName="TooltipTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },            
        };
    }
}
