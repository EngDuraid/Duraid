#pragma checksum "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\CategoryUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fa75a33dd92b3c5a628d5c809c9a074e3841b29"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/categories/update/{id}")]
    public partial class CategoryUpdate : CategoryUpdateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Duraid.Blazor.Pages.Admin.Categories.Category>(0);
            __builder.AddAttribute(1, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Duraid.Common.DTO.CategoryDTO>(
#nullable restore
#line 4 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\CategoryUpdate.razor"
                     Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Categories\CategoryUpdate.razor"
                                    Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
