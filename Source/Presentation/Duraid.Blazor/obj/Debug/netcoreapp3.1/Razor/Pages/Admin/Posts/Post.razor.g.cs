#pragma checksum "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a0b8e6a9a6be34085cb781cf0bfcd01afb76c3"
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
    public partial class Post : PostBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-xl-12 col-lg-12 col-md-12");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 6 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
             if (string.IsNullOrWhiteSpace(Post?.PostTitle))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, 
#nullable restore
#line 8 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " New Post");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 9 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "h3");
            __builder.AddContent(16, 
#nullable restore
#line 12 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 12 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                            Post.PostTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 13 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-xl-12 col-lg-12 col-md-12");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 19 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                 if (Categories is null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                    ");
            __builder.AddMarkupContent(33, "<div class=\"alert alert-warning\">Loadding</div>\r\n");
#nullable restore
#line 22 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                    ");
            __builder.AddMarkupContent(35, "<srtong class=\"col-form-label\">Categories: </srtong>\r\n                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-check form-check-inline");
            __builder.AddMarkupContent(38, "\r\n\r\n                        ");
            __builder.OpenElement(39, "select");
            __builder.AddAttribute(40, "class", "form-control form-check-input");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                        SelectedCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCategoryId = __value, SelectedCategoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "option");
            __builder.AddAttribute(45, "value", 
#nullable restore
#line 29 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                            Guid.Empty

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(46, "Select category");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n");
#nullable restore
#line 31 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                             foreach (var cnt in Categories)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                                ");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", 
#nullable restore
#line 33 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                cnt.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, 
#nullable restore
#line 33 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                 cnt.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 34 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-outline-dark input-group-prepend");
            __builder.AddAttribute(57, "title", "Add category to post");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                                                                         AddPostCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "\r\n                            <span class=\"oi oi-plus\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 41 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "p");
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 44 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                 if (PostCategories != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-check form-check-inline");
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.AddMarkupContent(70, "<strong class=\"col-form-label\">Post categories:   </strong>\r\n                        ");
            __builder.OpenElement(71, "ul");
            __builder.AddAttribute(72, "class", "col-form-label list-inline list-unstyled");
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 49 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                             foreach (var category in PostCategories)
                            {


#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                                ");
            __builder.OpenElement(75, "li");
            __builder.AddAttribute(76, "class", "list-inline-item");
            __builder.AddMarkupContent(77, "\r\n                                    ");
            __builder.OpenElement(78, "span");
            __builder.AddAttribute(79, "class", "badge badge-light");
            __builder.AddMarkupContent(80, "\r\n                                        ");
            __builder.OpenElement(81, "i");
            __builder.AddAttribute(82, "class", "oi oi-delete");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                            ()=> RemoveCategory(category)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                        ");
            __builder.OpenElement(85, "span");
            __builder.AddMarkupContent(86, "\r\n                                            ");
            __builder.AddContent(87, 
#nullable restore
#line 56 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                             category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(88, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 60 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 63 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "row");
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-xl-12 col-lg-12 col-md-12");
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(105);
            __builder.AddAttribute(106, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 69 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                              Post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 69 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                    SaveAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(110);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n\r\n                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group");
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __builder2.AddMarkupContent(115, "<p> Post title</p>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(116);
                __builder2.AddAttribute(117, "class", "form-control");
                __builder2.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                                  Post.PostTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Post.PostTitle = __value, Post.PostTitle))));
                __builder2.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Post.PostTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n                    ");
                __Blazor.Duraid.Blazor.Pages.Admin.Posts.Post.TypeInference.CreateValidationMessage_0(__builder2, 122, 123, 
#nullable restore
#line 75 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                              () => Post.PostTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(124, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n\r\n                ");
                __builder2.OpenComponent<Duraid.Blazor.Shared.Helper.RichEditor>(126);
                __builder2.AddComponentReferenceCapture(127, (__value) => {
#nullable restore
#line 84 "D:\Repos\Duraid\Source\Presentation\Duraid.Blazor\Pages\Admin\Posts\Post.razor"
                                                               RichEditor = (Duraid.Blazor.Shared.Helper.RichEditor)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n\r\n                ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "btn-block");
                __builder2.AddMarkupContent(131, "\r\n                    ");
                __builder2.AddMarkupContent(132, "<button class=\"btn btn-outline-primary\" type=\"submit\" title=\"Save\"><span class=\"oi oi-check\"></span></button>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(133);
                __builder2.AddAttribute(134, "href", "admin/posts");
                __builder2.AddAttribute(135, "class", "btn btn-dark");
                __builder2.AddAttribute(136, "title", "Back");
                __builder2.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(138, "<span class=\"oi oi-arrow-circle-left\"></span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(139, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(141, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n\r\n");
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
