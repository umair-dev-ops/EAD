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
#nullable restore
#line 11 "C:\EAD\EAD_Project\EAD_Project\Client\_Imports.razor"
using EAD_Project.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/showcatalog")]
    public partial class ShowCatalog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ShowCatalog.razor"
 
    private void PlaceOrder()
    {
        Console.WriteLine("placing order");
    }

    public Cart Cart { get; set; } = new Cart();

    private void AddtoCart(Product product)
    {
        Console.WriteLine($"Product added: {@product.Name}");
        Cart.Add(product.Id);
    }
    private void RemoveFromCart(int pos)
    {
        Console.WriteLine($"Product removed at: {pos}");
        Cart.Remove(pos);
    }
    

    protected async override Task OnInitializedAsync()
    {
        Catalog = await svc.GetCatalog();
        await base.OnInitializedAsync();
    }


    private Catalog Catalog { get; set; } = new Catalog();

    /*{
        Products = new List<Product>
        {
            new Product(1,"Table",8000,Category.Furniture),
            new Product(2,"Jeans",2000,Category.Cloth),
            new Product(3,"FootBall",1000,Category.Sport)
        }
    };*/


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService svc { get; set; }
    }
}
#pragma warning restore 1591
