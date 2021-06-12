#pragma checksum "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7bc77ef3f6efe9a53e7da5de7d5361a43c6785"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width: 18rem;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "class", "card-img-top");
            __builder.AddAttribute(6, "height", "150");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 2 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
                                                 ProductImage(Product.Category)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "h5");
            __builder.AddAttribute(14, "class", "card-title");
            __builder.AddContent(15, 
#nullable restore
#line 4 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
                                Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.AddContent(19, 
#nullable restore
#line 5 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
                              Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "card-text");
            __builder.AddContent(24, 
#nullable restore
#line 6 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
                              Product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-footer");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "#");
            __builder.AddAttribute(32, "class", 
#nullable restore
#line 8 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
                                ButtonClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
                           async()=> await SelectedProduct.InvokeAsync(Product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\r\n               ");
            __builder.AddContent(35, 
#nullable restore
#line 11 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
                ButtonTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\EAD\EAD_Project\EAD_Project\Client\Pages\ProductItem.razor"
       
    [Parameter]
    public Product Product { get; set; }

    [Parameter]
    public string ButtonTitle { get; set; }

    [Parameter]
    public string ButtonClass { get; set; }

    [Parameter]
    public EventCallback<Product> SelectedProduct { get; set; }

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
