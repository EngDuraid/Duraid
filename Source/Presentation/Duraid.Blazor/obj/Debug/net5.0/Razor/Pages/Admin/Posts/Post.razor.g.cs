#pragma checksum "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa1012618ec98932d6d43c81eee2ea46395b0016"
// <auto-generated/>
#pragma warning disable 1591
namespace Duraid.Blazor.Pages.Admin.Posts
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
    public partial class Post : PostBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
#nullable restore
#line 3 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
     if (ErrorMessageIsVisible)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "alert alert-warning alert-dismissible fade show");
            __builder.AddAttribute(6, "role", "alert");
            __builder.AddMarkupContent(7, "<strong>Holy guacamole!</strong> ");
            __builder.AddContent(8, 
#nullable restore
#line 7 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                  ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, ".\r\n                ");
            __builder.AddMarkupContent(10, "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "toast");
            __builder.AddAttribute(14, "role", "alert");
            __builder.AddAttribute(15, "aria-live", "assertive");
            __builder.AddAttribute(16, "aria-atomic", "true");
            __builder.AddMarkupContent(17, @"<div class=""toast-header""><img src=""..."" class=""rounded mr-2"" alt=""..."">
                <strong class=""mr-auto"">Bootstrap</strong>
                <small>11 second ago</small>
                <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>
            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "toast-body");
            __builder.AddContent(20, 
#nullable restore
#line 23 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                 ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-xl-12 col-lg-12 col-md-12");
#nullable restore
#line 29 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
             if (string.IsNullOrWhiteSpace(Post?.PostTitle))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "h3");
            __builder.AddContent(26, 
#nullable restore
#line 31 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " New Post");
            __builder.CloseElement();
#nullable restore
#line 32 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "h3");
            __builder.AddContent(29, 
#nullable restore
#line 35 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " ");
            __builder.AddContent(31, 
#nullable restore
#line 35 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                            Post.PostTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenComponent<Duraid.Blazor.Pages.Admin.PostCategories.PostCategory>(35);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenComponent<Duraid.Blazor.Shared.Helper.PhotoUploader>(39);
            __builder.AddAttribute(40, "PhotoDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Duraid.Common.DTO.ImageDto>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Duraid.Common.DTO.ImageDto>(this, 
#nullable restore
#line 44 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                 PhotoDeleted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "PhotoInserted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Duraid.Common.DTO.ImageDto>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Duraid.Common.DTO.ImageDto>(this, 
#nullable restore
#line 44 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                                              PhotoInserted

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        \r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-xl-12 col-lg-12 col-md-12");
#nullable restore
#line 49 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
             if (Post != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(47);
            __builder.AddAttribute(48, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 51 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                  Post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 51 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                        SaveAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(51);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "<p> Post title</p>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                      Post.PostTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Post.PostTitle = __value, Post.PostTitle))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Post.PostTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __Blazor.Duraid.Blazor.Pages.Admin.Posts.Post.TypeInference.CreateValidationMessage_0(__builder2, 62, 63, 
#nullable restore
#line 57 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                  () => Post.PostTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n                    ");
                __builder2.OpenComponent<Duraid.Blazor.Shared.Helper.RichEditor>(65);
                __builder2.AddAttribute(66, "QuillContent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                                              Post.PostContent

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentReferenceCapture(67, (__value) => {
#nullable restore
#line 66 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                   RichEditor = (Duraid.Blazor.Shared.Helper.RichEditor)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(69, @"<div class=""btn-block""><button class=""btn btn-outline-primary"" type=""submit"" title=""Save""><span class=""oi oi-check""></span></button>
                        <a href=""admin/posts"" class=""btn btn-dark"" title=""Back""><span class=""oi oi-arrow-circle-left""></span></a></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 74 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "<h4>Loading..</h4>");
#nullable restore
#line 78 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Duraid.Blazor.Pages.Admin.Posts.Post
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
