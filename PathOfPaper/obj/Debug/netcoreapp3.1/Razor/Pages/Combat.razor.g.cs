#pragma checksum "C:\PathOfPaper\PathOfPaper\Pages\Combat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7bbe52ac450159c8b4062d49f061cb9e061fbb"
// <auto-generated/>
#pragma warning disable 1591
namespace PathOfPaper.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using PathOfPaper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\PathOfPaper\PathOfPaper\_Imports.razor"
using PathOfPaper.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/combat")]
    public partial class Combat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
        #hp {
            background-image: url(./images/globe_hp.png);
            float: left;
        }

        #mana {
            background-image: url(./images/globe_mana.png);
            float: right;
        }

        .bubble {
            width: 200px;
            height: 250px;
            background-repeat: no-repeat;
            background-position: 0 50px;
            position: relative;
            margin: 10px;
            text-align: center;
            font-weight: 700;
        }
    </style>

combat page

");
            __builder.AddMarkupContent(1, @"<div>
    <div class=""bubble"" id=""hp"">
        Reserved:
        <span class=""reserved ng-binding"">
            0%
            <em>(0%)</em>
        </span><br>
        Life:
        <span class=""total ng-binding"">
            1000
            <em class=""ng-binding ng-hide"">(1000)</em>
            / 1000
        </span>
        <div style=""height: 0px""></div>
        <div class=""droppable"" style=""height: 0px""></div>
    </div>
    
    <div class=""bubble"" id=""mana"">
        Reserved:
        <span class=""reserved ng-binding"">
            0%
            <em>(0%)</em>
        </span><br>
        Life:
        <span class=""total ng-binding"">
            1000
            <em class=""ng-binding ng-hide"">(1000)</em>
            / 1000
        </span>
        <div style=""height: 0px""></div>
        <div class=""droppable"" style=""height: 0px""></div>
    </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
