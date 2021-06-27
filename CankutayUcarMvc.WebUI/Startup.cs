using CankutayUcarMvc.Business.Abstract;
using CankutayUcarMvc.Business.Concrete;
using CankutayUcarMvc.DataAccess.Abstract;
using CankutayUcarMvc.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CankutayUcarMvc.WebUI
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<ICategoryBs, CategoryBs>();

            services.AddSingleton<IManagerRepository, ManagerRepository>();
            services.AddSingleton<IManagerBs, ManagerBs>();

            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductBs, ProductBs>();

            services.AddSingleton<IProductPhotoRepository, ProductPhotoRepository>();
            services.AddSingleton<IProductPhotoBs, ProductPhotoBs>();

            services.AddSession();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "AdminPanelGiris",
                    areaName: "AdminPanel",
                    pattern: "admin",
                    defaults: new { controller = "Admin", action = "LogIn" });

                endpoints.MapAreaControllerRoute(
                    name: "AdminPanelDashBoard",
                    areaName: "AdminPanel",
                    pattern: "dashboard",
                    defaults: new { controller = "DashBoard", action = "Index" });

                endpoints.MapAreaControllerRoute(
                   name: "AdminPanelForgotPassword",
                   areaName: "AdminPanel",
                   pattern: "forgotPassword",
                   defaults: new { controller = "Admin", action = "ForgotPassword" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
