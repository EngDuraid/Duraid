﻿using AutoMapper;
using Duraid.Infrastructure.Mapping.Profiles;
using Duraid.Infrastructure.Services.Data.Categories;
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

        }

        private static void ConfigureAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryProfile));
        }
    }
}