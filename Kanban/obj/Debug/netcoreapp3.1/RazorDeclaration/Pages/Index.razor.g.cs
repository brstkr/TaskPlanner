#pragma checksum "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662de76db518b2a9baeb6d306bc14ac97ed97640"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Kanban.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Kanban;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\_Imports.razor"
using Kanban.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\Pages\Index.razor"
using Kanban.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\Pages\Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 236 "C:\Users\Shadow\source\repos\TaskPlanner\Kanban\Pages\Index.razor"
       
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
#pragma warning restore 1591
