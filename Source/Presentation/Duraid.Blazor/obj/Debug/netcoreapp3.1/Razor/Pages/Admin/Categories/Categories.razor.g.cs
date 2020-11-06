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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/categories")]
    public partial class Categories : CategoriesBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<div class=""row"">
        <div class=""col-lg-11 col-md-11"">
            <h3>Categories Managements</h3>
        </div>
        <span class=""col-lg-1 col-md-1"">
            <a href=""/admin/categories/create"" class=""btn btn-primary"" title=""Create new category"">
                <span class=""oi oi-plus""></span>
            </a>

        </span>
    </div>
    
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 19 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
         if (Categories is null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.AddMarkupContent(8, "<h4>Loading..</h4>\r\n");
#nullable restore
#line 22 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
        }
        else if (Categories?.Count() < 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.AddMarkupContent(10, "<h4>There is no categories inserted yet!</h4>\r\n");
#nullable restore
#line 26 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-lg-12 col-md-12");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.AddMarkupContent(18, @"<thead>
                        <tr>
                            <th>
                                Category name
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(19, "tbody");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 40 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                         foreach (var category in Categories)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                            ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "td");
            __builder.AddMarkupContent(25, "\r\n                                    ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "admin/categories/" + (
#nullable restore
#line 44 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                               category.CategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                                        ");
            __builder.AddContent(29, 
#nullable restore
#line 45 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                         category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.OpenElement(33, "td");
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                                               e => Delete(category.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "title", "Delete category");
            __builder.AddMarkupContent(39, "\r\n                                        <span class=\"oi oi-trash\"></span>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n                                    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-warning");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                                                e=>Edit(category.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "title", "Update category");
            __builder.AddMarkupContent(45, "\r\n                                        <span class=\"oi oi-pencil\"></span>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 58 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 62 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.OpenComponent<Duraid.Blazor.Shared.Helper.Confirm>(56);
            __builder.AddAttribute(57, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 66 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\Categories.razor"
                                                                                     ConfirmDeleteAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(58, (__value) => {
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
