using Duraid.BusinessLogic.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.BusinessLogic
{
    public static class DependencyInjection
    {
        public static void AddBusinessLogic(this IServiceCollection services)
        {
            services.AddTransient(typeof(IFilter<>), typeof(Filter<>));
            services.AddTransient(typeof(ICreateSaver<>), typeof(CreateSaver<>));
            services.AddTransient(typeof(IUpdateSaver<>), typeof(UpdateSaver<>));
            services.AddTransient(typeof(IDeleteSaver<>), typeof(DeleteSaver<>));
            services.AddTransient(typeof(ICommander<>), typeof(Commander<>));
            services.AddTransient(typeof(IReadById<>), typeof(ReaderById<>));
            services.AddTransient(typeof(IReadAll<>), typeof(ReadAll<>));
            services.AddTransient<IDateTime,MachineDateTime>();
        }
    }
}
