#pragma checksum "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsBlazor\HeaderPagina.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f17209de0c5c733accdb167bdfa060b10118158"
// <auto-generated/>
#pragma warning disable 1591
namespace SystemSP.ComponentsBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using Toolbelt.Blazor.I18nText;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentsBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Intelligence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Entitys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentsProyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentesCompartidos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentsVista;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentesAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.I18nText;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using DTOSystemSp.EntitysInicioApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\_Imports.razor"
using DTOSystemSp.EntitysFormProject;

#line default
#line hidden
#nullable disable
    public partial class HeaderPagina : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "info-Head headerPublciacion");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div>\r\n        <img src=\"/images/PageImage/SystemLogo.svg\" height=\"150\" width=\"150\" alt=\"logo\">\r\n        <img src=\"/images/PageImage/SystemSPTxt.svg\" height=\"200\" width=\"200\" alt=\"txtLogo\">\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "userBotons");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<SystemSP.ComponentsBlazor.BotonUsuario>(7);
            __builder.AddAttribute(8, "Texto", "Login");
            __builder.AddAttribute(9, "Login", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsBlazor\HeaderPagina.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenComponent<SystemSP.ComponentsBlazor.BotonUsuario>(11);
            __builder.AddAttribute(12, "Texto", "Registro");
            __builder.AddAttribute(13, "Login", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsBlazor\HeaderPagina.razor"
                                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<SystemSP.ComponentesCompartidos.SelectorIdioma>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
