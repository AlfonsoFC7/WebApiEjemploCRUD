// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WCont_Metas.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using WCont_Metas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using WCont_Metas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\Pages\CMetas.razor"
using WCont_Metas.Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\Pages\CMetas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\Pages\CMetas.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CMetas")]
    public partial class CMetas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\core\source\repos\WebApiMETAS\WCont_Metas\Client\Pages\CMetas.razor"
        private string? url = "https://localhost:7094/api/Clientes";
    private Int32 var_IdMeta;
    private Int32? var_IdTarea;
    private string? var_Nombre, var_direccion;
    private DateTime? var_Fecha;
    // Enviar Parametros a variables locales
    void enviarParametros(Int32 id, string? nom, DateTime? fech, int? IdTar)
    {
        var_IdMeta = id;
        var_Nombre = nom;
        var_Fecha = fech;
        var_IdTarea = IdTar;


    }
    // Crear
    private async Task Crear()
    {
        var metas = ClientFactory.CreateClient();
        var addItem = new METAS { Nombre = var_Nombre, Fecha = var_Fecha, IdTarea = var_IdTarea};
        await metas.PostAsJsonAsync(url, addItem);

        await OnInitializedAsync();
    }
    // Actualizar
    private async Task Actualizar()
    {
        var metas = ClientFactory.CreateClient();
        var addItem = new METAS { IdMeta = var_IdMeta, Nombre = var_Nombre, Fecha = var_Fecha, IdTarea = var_IdTarea};
        await metas.PutAsJsonAsync($"{url}/{var_IdMeta}", addItem);
        //url/var_idcliente
        // https://localhost:7094/api/Clientes/1
        await OnInitializedAsync();
    }
    // Eliminar
    private async Task Eliminar()
    {
        var metas = ClientFactory.CreateClient();
        await metas.DeleteAsync($"{url}/{var_IdMeta}");
        //url/var_idcliente
        // https://localhost:7094/api/Clientes/1
        await OnInitializedAsync();
    }
    private IEnumerable<METAS>? imetas = Array.Empty<METAS>();
    private bool getClienteError;
    private bool shouldRender;

    protected override bool ShouldRender() => shouldRender;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            url);
        request.Headers.Add("Accept", "application/vnd.github.v3+json");
        request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

        var metas = ClientFactory.CreateClient();

        var response = await metas.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            imetas = await JsonSerializer.DeserializeAsync
                <IEnumerable<METAS>>(responseStream);
        }
        else
        {
            getClienteError = true;
        }

        shouldRender = true;
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
