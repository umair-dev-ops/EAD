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
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
       
    [Parameter]
    public Product Product { get; set; }

    [Parameter]
    public string ButtonTitle { get; set; }

    [Parameter]
    public string ButtonClass { get; set; }

    [Parameter]
    public EventCallback<Product> SelectedProduct { get; set; }

    //ye abi bnaya ha
    [Parameter]
    public EventCallback<int> Counter { get; set; }

    private string ProductImage(Category category)
    {

        return $"Images/{category.ToString().ToLower()}.jpg";

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
