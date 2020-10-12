using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompactStoreConnection.Controllers;
using CompactStoreConnection.DBConnections;
using CompactStoreConnection.Models;
using CompactStoreConnection.Repositorys;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CompactStoreConnection
{
    public class Startup
    {
        IConfiguration _configuration;

        public Startup(IConfiguration conf)
        {
            _configuration = conf;
        }

      

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var conn = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(Options => Options.UseSqlServer(conn));

            services.AddTransient<IItemsInterface, ItemsRepository>();
            services.AddTransient<IStorePositionItemInterface, StorePositionItemRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
  

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Items}/{action=List}/{id?}");
            });


          


         

        }
    }
}
