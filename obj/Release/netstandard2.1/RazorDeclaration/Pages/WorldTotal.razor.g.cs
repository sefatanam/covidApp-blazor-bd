#pragma checksum "C:\Users\Sefat\Source\Repos\CovidStatistics\Pages\WorldTotal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f322489c060cf9956d29b925fec852af02c6e9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CovidStatistics.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using CovidStatistics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using CovidStatistics.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sefat\Source\Repos\CovidStatistics\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sefat\Source\Repos\CovidStatistics\Pages\WorldTotal.razor"
using CovidStatistics.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sefat\Source\Repos\CovidStatistics\Pages\WorldTotal.razor"
using CovidStatistics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sefat\Source\Repos\CovidStatistics\Pages\WorldTotal.razor"
using CovidStatistics.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/worldTotal")]
    public partial class WorldTotal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\Sefat\Source\Repos\CovidStatistics\Pages\WorldTotal.razor"
       
    private ApiServices _service = new ApiServices();
    private WorldWideInfo _worldWideInfo = new WorldWideInfo();
    private bool isShown { get; set; } = false;
    private DateTime DateTime { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {

            _worldWideInfo = await _service.AroundTheWorld();
            await Task.Delay(100);
            isShown = true;

        }
        catch (Exception)
        {

            isShown = false;
        }


    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
