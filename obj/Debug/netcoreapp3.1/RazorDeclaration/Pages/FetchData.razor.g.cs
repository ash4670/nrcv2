// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace nrcv2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using nrcv2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using nrcv2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using nrcv2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ashwork\blazors\nrcv2\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ashwork\blazors\nrcv2\Pages\FetchData.razor"
using nrcv2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\ashwork\blazors\nrcv2\Pages\FetchData.razor"
       
    public List<Stock> stlist { get; set; }
    private Stock tableselectedrow;
    public void f_rowdblclicked(Stock arg) { tableselectedrow = arg; }
    public void f_rowclicked(Stock arg) { tableselectedrow = arg; }
    protected override async Task OnInitializedAsync()
    {
        using (var db = dbf.CreateDbContext())  stlist = await db.Stocks.Where(p => p.StockCode != "03").ToListAsync<Stock>();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<nrcwebContext> dbf { get; set; }
    }
}
#pragma warning restore 1591
