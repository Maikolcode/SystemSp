#pragma checksum "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\TarjetaEditarProyecto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6f4559b1becc9c90b8ffa59af1689eab8fa55b8"
// <auto-generated/>
#pragma warning disable 1591
namespace SystemSP.ComponentsProyecto
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
    public partial class TarjetaEditarProyecto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "UpdateName");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "src", "images/IconosCategorias/" + (
#nullable restore
#line 4 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\TarjetaEditarProyecto.razor"
                                           LeadingImage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "width", "30");
            __builder.AddAttribute(8, "height", "30");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "nombreTitulo");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "NombreDetails");
            __builder.AddContent(16, 
#nullable restore
#line 7 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\TarjetaEditarProyecto.razor"
                                  TituloTarjeta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "nameProyect");
            __builder.AddContent(20, 
#nullable restore
#line 8 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\TarjetaEditarProyecto.razor"
                                   SubTituloTarjeta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 11 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\TarjetaEditarProyecto.razor"
         if (TrailingImage)
         {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "            <button class=\"botonOpcionProject\"></button>\r\n");
#nullable restore
#line 14 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\TarjetaEditarProyecto.razor"
         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\TarjetaEditarProyecto.razor"
       
    [Parameter]
    public string TituloTarjeta { get; set; }
    [Parameter]
    public string SubTituloTarjeta { get; set; }
    [Parameter]
    public string LeadingImage { get; set; }
    [Parameter]
    public bool TrailingImage { get; set; }

    protected override void OnInitialized()
    {

        base.OnInitialized();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
