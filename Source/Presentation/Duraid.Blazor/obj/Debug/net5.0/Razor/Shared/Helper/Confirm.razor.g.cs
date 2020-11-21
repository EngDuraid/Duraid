#pragma checksum "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Shared\Helper\Confirm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78042306d6594892f65653ed2c2fd3da81c38de4"
// <auto-generated/>
#pragma warning disable 1591
namespace Duraid.Blazor.Shared.Helper
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Duraid.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Duraid.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Duraid.Common.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class Confirm : ConfirmBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Shared\Helper\Confirm.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.AddAttribute(5, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(6, "aria-hidden", "true");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-header");
            __builder.AddMarkupContent(14, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">Confirm Delete</h5>\r\n                    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "close");
            __builder.AddAttribute(18, "data-dismiss", "modal");
            __builder.AddAttribute(19, "aria-label", "Close");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Shared\Helper\Confirm.razor"
                                      ()=> OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<div class=\"modal-body\">\r\n                    Are you sure you want to delete?\r\n                </div>\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-footer");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-secondary");
            __builder.AddAttribute(29, "data-dismiss", "modal");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Shared\Helper\Confirm.razor"
                                      ()=> OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "\r\n                        Cancel\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Shared\Helper\Confirm.razor"
                                      ()=> OnConfirmationChange(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\r\n                        Delete\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Shared\Helper\Confirm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
