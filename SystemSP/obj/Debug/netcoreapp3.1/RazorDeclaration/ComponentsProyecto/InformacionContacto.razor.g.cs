#pragma checksum "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\InformacionContacto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dab3835d47d03a7c489302e81eb29ec89872b0d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class InformacionContacto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Desarrollo\SenaSystemSP\SystemSP\SystemSP\ComponentsProyecto\InformacionContacto.razor"
       
    private string _numeroTelefono = "3002309039";
    private string _direccionEmail = "Ernestocajar@outlook.com";
    private string _direccionFisica = "Calle 25 # 89 12";
    private string _mensaje = string.Empty;
    private async Task savePhone()
    {
        if (String.IsNullOrEmpty(_numeroTelefono))
        {

        }
        else
        {
            _mensaje = "Se ha actualizado el número de teléfono";
            await JsRun.InvokeVoidAsync(identifier: "alerta.MostrarAlerta");
        }

    }
    private async Task saveAddress()
    {
        if (String.IsNullOrEmpty(_direccionFisica))
        {

        }
        else
        {
            _mensaje = "Se ha actualizado su dirreccion";
            await JsRun.InvokeVoidAsync(identifier: "alerta.MostrarAlerta");
        }

    }
    private async Task saveEmail()
    {
        if (String.IsNullOrEmpty(_direccionEmail))
        {

        }
        else
        {
            _mensaje = "Se ha actualizado el correo electronico";
            await JsRun.InvokeVoidAsync(identifier: "alerta.MostrarAlerta");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRun { get; set; }
    }
}
#pragma warning restore 1591
