#pragma checksum "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f420e4a6440f7258aaac856e0cd9e0b69c25a37a"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskPlanner.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using TaskPlanner.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using TaskPlanner.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
using Kanban.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
using Syncfusion.Blazor.Kanban;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/overview")]
    public partial class Index : SampleBaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control-section");
            __builder.AddMarkupContent(2, "\r\n    ");
            __Blazor.TaskPlanner.Client.Pages.Index.TypeInference.CreateSfKanban_0(__builder, 3, 4, "kanban-overview", 5, "Status", 6, 
#nullable restore
#line 8 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                        Tasks

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 8 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Kanban.KanbanColumns>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n");
#nullable restore
#line 10 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
             foreach (ColumnsModel item in columnData)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(13, "                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Kanban.KanbanColumn>(14);
                    __builder3.AddAttribute(15, "HeaderText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                           item.HeaderText

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "KeyField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                       item.KeyField

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "AllowToggle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                                                    item.AllowToggle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Syncfusion.Blazor.Kanban.KanbanColumn>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n");
#nullable restore
#line 14 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                          
                            KanbanColumn column = (KanbanColumn)context;

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(20, "                            ");
                        __builder4.OpenElement(21, "div");
                        __builder4.AddAttribute(22, "class", "header-template-wrap");
                        __builder4.AddMarkupContent(23, "\r\n                                ");
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "header-icon" + " e-icons" + " " + (
#nullable restore
#line 17 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                 column.KeyField

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(26, "\r\n                                ");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddAttribute(28, "class", "header-text");
                        __builder4.AddContent(29, 
#nullable restore
#line 18 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                          column.HeaderText

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(30, "\r\n                            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(31, "\r\n");
                        __builder4.AddContent(32, "                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n");
#nullable restore
#line 23 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(34, "        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Kanban.KanbanCardSettings>(36);
                __builder2.AddAttribute(37, "ContentField", "Summary");
                __builder2.AddAttribute(38, "HeaderField", "Title");
                __builder2.AddAttribute(39, "SelectionType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Kanban.SelectionType>(
#nullable restore
#line 25 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                                       SelectionType.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(41, "\r\n");
#nullable restore
#line 27 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                  
                    KanbanDataModel card = (KanbanDataModel)context;

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(42, "                    ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "card-template" + " " + (
#nullable restore
#line 29 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                               card.Priority

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(45, "\r\n                        ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "e-card-header");
                    __builder3.AddMarkupContent(48, "\r\n                            ");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "class", "e-card-header-caption");
                    __builder3.AddMarkupContent(51, "\r\n                                ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "e-card-header-title e-tooltip-text");
                    __builder3.AddContent(54, 
#nullable restore
#line 32 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                                 card.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n                        ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "e-card-content e-tooltip-text");
                    __builder3.AddMarkupContent(60, "\r\n                            ");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "class", "e-text");
                    __builder3.AddContent(63, 
#nullable restore
#line 36 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                 card.Summary

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n                        ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "e-card-footer");
                    __builder3.AddMarkupContent(68, "\r\n");
#nullable restore
#line 39 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                              
                                string[] tags = card.Tags.Split(",");
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                 foreach (var tagIndex in Enumerable.Range(0, tags.Count()))
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(69, "                                    ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "e-card-tag e-tooltip-text");
                    __builder3.AddContent(72, 
#nullable restore
#line 43 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                            tags[tagIndex]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n");
#nullable restore
#line 44 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(74, "                            ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "class", "e-card-avatar");
                    __builder3.AddMarkupContent(77, "\r\n");
#nullable restore
#line 47 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                  
                                    string[] strSplit = card.Assignee.Split();
                                    foreach (string res in strSplit)
                                    {
                                        

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(78, 
#nullable restore
#line 51 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                         res.Substring(0, 1).ToUpper()

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 51 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
                                                                      
                                    }
                                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(79, "                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\r\n");
                    __builder3.AddContent(83, "            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Kanban.KanbanSwimlaneSettings>(85);
                __builder2.AddAttribute(86, "KeyField", "Assignee");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(88, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
            __builder.AddMarkupContent(90, "<style type=\"text/css\">\r\n\r\n    .e-kanban .header-template-wrap {\r\n        display: inline-flex;\r\n        font-size: 15px;\r\n        font-weight: 500;\r\n    }\r\n\r\n        .e-kanban .header-template-wrap .header-icon {\r\n            font-family: \'Kanban priority icons\';\r\n            margin-top: 3px;\r\n            width: 10%;\r\n        }\r\n\r\n        .e-kanban .header-template-wrap .header-text {\r\n            margin-left: 15px;\r\n        }\r\n\r\n    .e-kanban.e-rtl .header-template-wrap .header-text {\r\n        margin-right: 15px;\r\n    }\r\n\r\n    .e-kanban.e-rtl .e-card-avatar {\r\n        left: 12px;\r\n        right: auto;\r\n    }\r\n\r\n    .e-kanban .e-card-avatar {\r\n        width: 30px;\r\n        height: 30px;\r\n        text-align: center;\r\n        background: gainsboro;\r\n        color: #6b6b6b;\r\n        border-radius: 50%;\r\n        position: absolute;\r\n        right: 12px;\r\n        bottom: 10px;\r\n        font-size: 12px;\r\n        font-weight: 400;\r\n        padding: 10px 0px 0px 1px;\r\n    }\r\n\r\n    .e-kanban .Open::before {\r\n        content: \'\\e700\';\r\n        color: #0251cc;\r\n        font-size: 16px;\r\n    }\r\n\r\n    .e-kanban .InProgress::before {\r\n        content: \'\\e703\';\r\n        color: #ea9713;\r\n        font-size: 16px;\r\n    }\r\n\r\n    .e-kanban .e-image img {\r\n        background: #ececec;\r\n        border: 1px solid #c8c8c8;\r\n        border-radius: 50%;\r\n    }\r\n\r\n    .e-kanban .Review::before {\r\n        content: \'\\e701\';\r\n        color: #8e4399;\r\n        font-size: 16px;\r\n    }\r\n\r\n    .e-kanban .Close::before {\r\n        content: \'\\e702\';\r\n        color: #63ba3c;\r\n        font-size: 16px;\r\n    }\r\n\r\n    .e-kanban .e-card .e-card-tag {\r\n        background: #ececec;\r\n        color: #6b6b6b;\r\n        margin-right: 5px;\r\n        line-height: 1.1;\r\n        font-size: 13px;\r\n        border-radius: 3px;\r\n        padding: 4px;\r\n    }\r\n\r\n    .e-kanban .e-card-footer {\r\n        display: flex;\r\n        padding: 0px 12px 12px;\r\n        line-height: 1;\r\n        height: 35px;\r\n    }\r\n\r\n    .card-template.Low {\r\n        border-left: 3px solid #ffd600\r\n    }\r\n\r\n    .card-template.High {\r\n        border-left: 3px solid #990099\r\n    }\r\n\r\n    .card-template.Normal {\r\n        border-left: 3px solid #66cc33\r\n    }\r\n\r\n    .card-template.Critical {\r\n        border-left: 3px solid #cc0000\r\n    }\r\n\r\n    .e-kanban.e-rtl .card-template {\r\n        border-left: none\r\n    }\r\n\r\n        .e-kanban.e-rtl .card-template.Low {\r\n            border-right: 3px solid #ffd600\r\n        }\r\n\r\n        .e-kanban.e-rtl .card-template.High {\r\n            border-right: 3px solid #990099\r\n        }\r\n\r\n        .e-kanban.e-rtl .card-template.Normal {\r\n            border-right: 3px solid #66cc33\r\n        }\r\n\r\n        .e-kanban.e-rtl .card-template.Critical {\r\n            border-right: 3px solid #cc0000\r\n        }\r\n\r\n    @font-face {\r\n        font-family: \'Kanban priority icons\';\r\n        src: url(data:application/x-font-ttf;charset=utf-8;base64,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) format(\'truetype\');\r\n        font-weight: normal;\r\n        font-style: normal;\r\n    }\r\n\r\n    [class^=\"sf-icon-\"],\r\n    [class*=\" sf-icon-\"] {\r\n        font-family: \'Kanban priority icons\' !important;\r\n        speak: none;\r\n        font-size: 55px;\r\n        font-style: normal;\r\n        font-weight: normal;\r\n        font-variant: normal;\r\n        text-transform: none;\r\n        line-height: 1;\r\n        -webkit-font-smoothing: antialiased;\r\n        -moz-osx-font-smoothing: grayscale;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 209 "C:\Users\Shadow\source\repos\TaskPlanner\TaskPlanner\Client\Pages\Index.razor"
       
    private List<KanbanDataModel> Tasks = new KanbanDataModel().GetCardTasks();
    private List<ColumnsModel> columnData = new List<ColumnsModel>()
{
            new ColumnsModel(){ HeaderText= "To Do", KeyField= "Open", AllowToggle= true },
            new ColumnsModel(){ HeaderText= "In Progress", KeyField= "InProgress", AllowToggle= true },
            new ColumnsModel(){ HeaderText= "In Review", KeyField= "Review", AllowToggle= true },
            new ColumnsModel(){ HeaderText= "Done", KeyField= "Close", AllowToggle= true }
        };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TaskPlanner.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfKanban_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<TValue> __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Kanban.SfKanban<TValue>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "KeyField", __arg1);
        __builder.AddAttribute(__seq2, "DataSource", __arg2);
        __builder.AddAttribute(__seq3, "EnableTooltip", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
