#pragma checksum "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5b2e59538d7e15708a17f6932f18282578d1e7"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD_Project0.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head><link rel=\"stylesheet\" href=\"../wwwroot/css/app.css\"></head>\r\n");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "style", " background-color: #000000 !important;");
            __builder.AddAttribute(3, "class", "navbar navbar-expand-sm navbar-toggleable-sm navbar-dark border-bottom box-shadow mb-3 fixed-top");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "class", "navbar-brand text-light");
            __builder.AddAttribute(8, "href", "/");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<img style=\"margin-top:12px;\" src=\"/Images/default-removebg (2).png\" height=\"50px\" width=\"100px\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "navbar-toggler");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "data-toggle", "collapse");
            __builder.AddAttribute(17, "data-target", ".navbar-collapse");
            __builder.AddAttribute(18, "aria-controls", "navbarSupportedContent");
            __builder.AddAttribute(19, "aria-expanded", "false");
            __builder.AddAttribute(20, "aria-label", "Toggle navigation");
            __builder.AddMarkupContent(21, "<span class=\"navbar-toggler-icon\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "padding-top:10px;");
            __builder.AddAttribute(25, "class", (
#nullable restore
#line 13 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Shared\NavMenu.razor"
                                               NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse" + " d-sm-inline-flex" + " flex-sm-row-reverse");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Shared\NavMenu.razor"
                                                                                                                               CollapseNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "navbar-nav flex-grow-1");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link text-light");
            __builder.AddAttribute(33, "href", "ShowCatalog");
            __builder.AddAttribute(34, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Shared\NavMenu.razor"
                                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(36, "Shop");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.AddMarkupContent(38, "<li class=\"nav-item\"><a class=\"nav-link text-light\" href=\"counter\">Categories</a></li>\r\n                ");
            __builder.AddMarkupContent(39, "<li class=\"nav-item\"><a class=\"nav-link text-light\" href=\"fetchdata\">Sell</a></li>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "ul");
            __builder.AddAttribute(42, "style", "margin-right:-6%");
            __builder.AddAttribute(43, "class", "nav navbar-nav navbar-right");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(46, "li");
                __builder2.AddAttribute(47, "style", "padding-left:4px");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
                __builder2.AddAttribute(49, "class", "text-light");
                __builder2.AddAttribute(50, "href", "ShoppingCart");
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(52, "span");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "id", "lblCartCount");
                    __builder3.AddContent(55, 
#nullable restore
#line 31 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Shared\NavMenu.razor"
                                                Model.CounterCount

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "<img style=\"margin-bottom:5px\" height=\"30\" width=\"30\" src=\"/Images/icons8-fast-cart-32.png\">\r\n                        <span class=\"badge badge-info my-cart-badge\"></span>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, " Cart\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "li");
            __builder.AddAttribute(60, "style", "padding-top:22px;padding-left:18px");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "text-light");
            __builder.AddAttribute(63, "href", "login");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "<span><img height=\"22\" width=\"22\" src=\"/Images/icons8-signin-50.png\"></span> ");
                __builder2.OpenComponent<EAD_Project0.Client.Shared.LoginDisplay>(66);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Shared\NavMenu.razor"
        bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void CollapseNavMenu()
    {
        collapseNavMenu = true;
    }
 
    protected override void OnInitialized()
    {
        Model.OnChange += StateHasChanged;
        base.OnInitialized();
    }

    public void Dispose()
    {
        Model.OnChange -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CounterStateService Model { get; set; }
    }
}
#pragma warning restore 1591