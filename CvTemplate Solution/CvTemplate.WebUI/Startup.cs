using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvTemplate.Domain.Models.DataContexts;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using CvTemplate.Application.Core.Providers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using CvTemplate.Application.Core.Middlewares;

namespace CvTemplate.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddNewtonsoftJson(cfg =>
                    cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                ); 

            services.AddDbContext<CvTemplateDbContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("connectionString"));
            }, ServiceLifetime.Scoped);

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddRouting(cfg => cfg.LowercaseUrls = true);

        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseRouting();

            app.UseRequestLocalization(cfg => {

                cfg.AddSupportedUICultures("az", "en");
                cfg.AddSupportedCultures("az", "en");

                cfg.RequestCultureProviders.Clear();
                cfg.RequestCultureProviders.Add(new CultureProvider());
            });

            app.UseAudit();

            app.UseAuthorization();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                      name: "areas-with-lang",
                      pattern: "{lang}/{area:exists}/{controller=Dashboard}/{action=Index}/{id?}",
                      constraints: new
                      {
                          lang = "en|az|ru"
                      }
                    );

                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute("default-with-lang", "{lang}/{controller=home}/{action=about}/{id?}",
                    constraints: new
                    {
                        lang = "en|az|ru"
                    });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=About}/{id?}");
            });
        }
    }
}
