#pragma checksum "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1871b88bf564cbbfe7fd2ee8f0fc7f7767ce8fb1"
// <auto-generated/>
#pragma warning disable 1591
namespace Duraid.Blazor.Pages.Admin.Categories
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/categories")]
    public partial class Categories : CategoriesBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, @"<div class=""row""><div class=""col-lg-11 col-md-11""><h3>Categories Managements</h3></div>
        <span class=""col-lg-1 col-md-1""><a href=""/admin/categories/create"" class=""btn btn-primary"" title=""Create new category""><span class=""oi oi-plus""></span></a></span></div>
    
    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 19 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
         if (Categories is null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<h4>Loading..</h4>");
#nullable restore
#line 22 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
        }
        else if (Categories?.Count() < 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<h4>There is no categories inserted yet!</h4>");
#nullable restore
#line 26 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-12 col-md-12");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(11, "<thead><tr><th>\r\n                                Category name\r\n                            </th>\r\n                            <th></th></tr></thead>\r\n                    ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 40 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                         foreach (var category in Categories)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "admin/categories/" + (
#nullable restore
#line 44 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                               category.CategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, 
#nullable restore
#line 45 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                         category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                                               e => Delete(category.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "title", "Delete category");
            __builder.AddMarkupContent(24, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n                                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-warning");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                                                e=>Edit(category.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "title", "Update category");
            __builder.AddMarkupContent(30, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenComponent<Duraid.Blazor.Shared.Helper.Confirm>(32);
            __builder.AddAttribute(33, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 66 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                                                     ConfirmDeleteAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(34, (__value) => {
#nullable restore
#line 66 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                           DeleteConfirmation = (Duraid.Blazor.Shared.Helper.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591