#pragma checksum "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba39edcbc641eb6a89474de13a3ee7a22ff1300d"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD_Project.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using EAD_Project.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using EAD_Project.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\_Imports.razor"
using EAD_Project.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-group");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 4 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\Pages\Index.razor"
 foreach (var product in Catalog.Products)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<EAD_Project.Client.Pages.ProductItem>(4);
            __builder.AddAttribute(5, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EAD_Project.Shared.Product>(
#nullable restore
#line 6 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\Pages\Index.razor"
                           product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 7 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, " ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\UMAIR AHMED\source\repos\EAD_Project\EAD_Project\Client\Pages\Index.razor"
 
    private Catalog Catalog { get; set; } = new Catalog
    {
        Products = new List<Product>
        {
            new Product(1,"Table",8000,Category.Furniture),
            new Product(1,"Jeans",2000,Category.Cloth),
            new Product(1,"FootBall",1000,Category.Sport)
        }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
