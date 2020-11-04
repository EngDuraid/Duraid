using Duraid.Blazor.Services;
using Duraid.Blazor.Services.Categories;
using Duraid.Blazor.Services.Posts;
using Duraid.Common.DTO;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            services.AddHttpClient<IPostServices, PostServices>(client =>
            {
                client.BaseAddress = new Uri(url);
            });
        }

    }
}
