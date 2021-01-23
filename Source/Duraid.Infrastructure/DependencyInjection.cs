using AutoMapper;
using Duraid.Infrastructure.Mapping.Profiles;
using Duraid.Infrastructure.Services.Data.Categories;
using Duraid.Infrastructure.Services.Data.PostCategories;
using Duraid.Infrastructure.Services.Data.Posts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Duraid.Infrastructure.Services.Data.Images;
using Duraid.Infrastructure.Services.Data.PostImages;

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

            services.AddTransient<IPostCategoryServices, PostCategoryServices>();
            services.AddTransient<IPostCategoryCommanderServices, PostCategoryCommanderServices>();
            
            services.AddTransient<IPostServices, PostServices>();
            services.AddTransient<IPostCommanderServices, PostCommanderServices>();

            services.AddTransient<IImageServices, ImageServices>();
            services.AddTransient<IImageCommanderServices, ImageCommanderServices>();

            services.AddTransient<IPostImageServices, PostImageServices>();
            services.AddTransient<IPostImageCommanderServices, PostImageCommanderServices>();
        }

        private static void ConfigureAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(typeof(PostProfile));
            services.AddAutoMapper(typeof(PostCategoryProfile));
            services.AddAutoMapper(typeof(ImageProfile));
            services.AddAutoMapper(typeof(PostImageProfile));
        }
    }
}
