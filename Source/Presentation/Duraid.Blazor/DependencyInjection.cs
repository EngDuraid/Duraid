using Duraid.Blazor.Services;
using Duraid.Blazor.Services.Categories;
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
        public static void ConfigureHttpClients(this IServiceCollection services)
        {
            services.AddHttpClient<ICategoryServices, CategoryServices>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44341/");
            });
            //services.AddTransient(typeof(ICategoryServices), typeof(CategoryServices));
            //services.AddHttpClient<IBrandService, BrandService>(client =>
            //{
            //    client.BaseAddress = new Uri("https://localhost:44320/");
            //});

            //services.AddHttpClient<IManufactureService, ManufactureService>(client =>
            //{
            //    client.BaseAddress = new Uri("https://localhost:44320/");
            //});
            //services.AddHttpClient<IProductService, ProductService>(client =>
            //{
            //    client.BaseAddress = new Uri("https://localhost:44320/");
            //});
        }

    }
}
