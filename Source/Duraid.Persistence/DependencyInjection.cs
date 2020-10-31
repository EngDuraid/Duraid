using Duraid.BusinessLogic.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Persistence
{
    public static class DependencyInjection
    {
        public static void ConfigurePersistence(this IServiceCollection services)
        {
            services.AddDbContext<DuraidDataContext>();
            services.AddTransient<IDataContext, DuraidDataContext>();
        }
    }
}
