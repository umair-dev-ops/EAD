// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EAD_Project.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using EAD_Project.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using EAD_Project.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using EAD_Project.Shared;

#line default
#line hidden
#nullable disable
    public partial class ShoppingCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ShoppingCart.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public Cart Cart { get; set; }

    public IEnumerable<Product> Products { get; set; }
    [Parameter]
    public Func<int,Product> GetProductFromId { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        Products = Cart.Orders.Select((id) =>
        GetProductFromId(id));

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
