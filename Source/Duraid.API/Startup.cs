using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.API.Connector;
using Duraid.BusinessLogic;
using Duraid.BusinessLogic.Common.Interfaces;
using Duraid.Infrastructure;
using Duraid.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Duraid.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();                       // new
            services.AddSignalR();                          // new
            services.AddControllers();
            services.AddBusinessLogic();
            services.AddInfrastructure();
            services.ConfigurePersistence();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
           
            app.UseHttpsRedirection();                          // new
            //app.UseBlazorFrameworkFiles();                    // new
            app.UseStaticFiles(); //new
            
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();


                endpoints.MapRazorPages();                      // new
                endpoints.MapFallbackToFile("index.html");      // new

                endpoints.MapHub<HubConnector>("/connector");   // new
            });
           
        }
    }
}
