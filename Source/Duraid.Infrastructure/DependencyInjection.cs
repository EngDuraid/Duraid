using AutoMapper;
using Duraid.Infrastructure.Mapping.Profiles;
using Duraid.Infrastructure.Services.Data.Categories;
using Duraid.Infrastructure.Services.Data.PostCategories;
using Duraid.Infrastructure.Services.Data.Posts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            ConfigureAutoMapper(services);
            AddDataService(services);
        }

        private static void AddDataService(IServiceCollection services)
        {
            services.AddTransient<ICategoryServices, CategoryServices>();
            services.AddTransient<ICategoryCommander, CategoryCommander>();

            services.AddTransient<IPostServices, PostServices>();
            services.AddTransient<IPostCommanderServices, PostCommanderServices>();
            
            services.AddTransient<IPostCategoryServices, PostCategoryServices>();
            services.AddTransient<IPostCategoryCommanderServices, PostCategoryCommanderServices>();
        }

        private static void ConfigureAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(typeof(PostProfile));
            services.AddAutoMapper(typeof(PostCategoryProfile));
        }
    }
}
