using Duraid.Blazor.Services;
using Duraid.Blazor.Services.Categories;
using Duraid.Blazor.Services.Common;
using Duraid.Blazor.Services.PostCategories;
using Duraid.Blazor.Services.Posts;
using Duraid.Common.DTO;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.Blazor.Pages.Admin.Posts;
using Duraid.Blazor.Services.Images;
using Duraid.Blazor.Services.PostImages;

namespace Duraid.Blazor
{
    public static class DependencyInjection
    {
        private readonly static string url = "https://localhost:44341/";
        public static void ConfigureHttpClients(this IServiceCollection services)
        {
            services.AddHttpClient<ICategoryServices, CategoryServices>(client =>
            {
                client.BaseAddress = new Uri(url);
            });
            services.AddHttpClient<IPostCategoryService,PostCategoryService>(client =>
            {
                client.BaseAddress = new Uri(url);
            });
            services.AddHttpClient<IPostServices, PostServices>(client =>
            {
                client.BaseAddress = new Uri(url);
            });

            services.AddHttpClient<IImageServices, ImageServices>(client =>
            {
                client.BaseAddress = new Uri(url);
            }); 
            services.AddHttpClient<IPostImageServices, PostImageServices>(client =>
            {
                client.BaseAddress = new Uri(url);
            });


            
        }
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IFileUploadService, FileUploadService>();
            services.AddTransient<IImageHelper, ImageHelper>();
        }

    }
}
