#pragma checksum "C:\Desarrollo\SystemSP\SystemSP\SystemSP\ComponentesAdmin\EstadisticasPlataforma.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc90c35d62da883b1a188a369f6397bfc4d08bb8"
// <auto-generated/>
#pragma warning disable 1591
namespace SystemSP.ComponentesAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentsBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Intelligence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Entitys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentsProyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentesCompartidos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentsVista;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using SystemSP.ComponentesAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using DTOSystemSp.EntitysInicioApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\_Imports.razor"
using DTOSystemSp.EntitysFormProject;

#line default
#line hidden
#nullable disable
    public partial class EstadisticasPlataforma : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "graficosContenedor");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "flexContext");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<SystemSP.ComponentesAdmin.OpcionesEstadisticas>(6);
            __builder.AddAttribute(7, "Titulo", "Visitas");
            __builder.AddAttribute(8, "Subtitulo", "Estadisticas visitas");
            __builder.AddAttribute(9, "ColorTarjeta", "#26D0D0");
            __builder.AddAttribute(10, "UrlImage", "libroPack.svg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<SystemSP.ComponentesAdmin.OpcionesEstadisticas>(12);
            __builder.AddAttribute(13, "Titulo", "Visitas");
            __builder.AddAttribute(14, "Subtitulo", "Estadisticas visitas");
            __builder.AddAttribute(15, "ColorTarjeta", "#186CFF");
            __builder.AddAttribute(16, "UrlImage", "libroPack.svg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenComponent<SystemSP.ComponentesAdmin.OpcionesEstadisticas>(18);
            __builder.AddAttribute(19, "Titulo", "Visitas");
            __builder.AddAttribute(20, "Subtitulo", "Estadisticas visitas");
            __builder.AddAttribute(21, "ColorTarjeta", "#FF0046");
            __builder.AddAttribute(22, "UrlImage", "libroPack.svg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenComponent<SystemSP.ComponentesAdmin.OpcionesEstadisticas>(24);
            __builder.AddAttribute(25, "Titulo", "Visitas");
            __builder.AddAttribute(26, "Subtitulo", "Estadisticas visitas");
            __builder.AddAttribute(27, "ColorTarjeta", "#8AA336");
            __builder.AddAttribute(28, "UrlImage", "libroPack.svg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.AddMarkupContent(31, "<section class=\"sobrasTarjetas cardBar\">\r\n        <canvas id=\"chartBarra\" class=\"canvasBarra\"></canvas>\r\n    </section>\r\n    ");
            __builder.AddMarkupContent(32, "<section class=\"sobrasTarjetas cardPie\">\r\n        <canvas id=\"chartTorta\"></canvas>\r\n    </section>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Desarrollo\SystemSP\SystemSP\SystemSP\ComponentesAdmin\EstadisticasPlataforma.razor"
       
    private int IndicadorCheart = 0;
    private void ClickHandler(int numeroParam)
    {
        IndicadorCheart = numeroParam;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JsRun.CrearCanvas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRun { get; set; }
    }
}
#pragma warning restore 1591
