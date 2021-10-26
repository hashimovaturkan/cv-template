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
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

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
            services.AddControllersWithViews(cfg =>
            {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());  

                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            })
                .AddNewtonsoftJson(cfg =>
                    cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                ); 

            services.AddDbContext<CvTemplateDbContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("connectionString"));
            }, ServiceLifetime.Scoped);

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddRouting(cfg => cfg.LowercaseUrls = true);

            services.AddIdentity<CvTemplateUser, CvTemplateRole>()
                .AddEntityFrameworkStores<CvTemplateDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<UserManager<CvTemplateUser>>(); 
            services.AddScoped<RoleManager<CvTemplateRole>>();  
            services.AddScoped<SignInManager<CvTemplateUser>>();  
            
            services.AddScoped<IClaimsTransformation, AppClaimProvider>();

            services.Configure<IdentityOptions>(cfg =>
            {
                cfg.Password.RequireDigit = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequiredUniqueChars = 1;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequiredLength = 3;

                cfg.User.RequireUniqueEmail = true;

                cfg.Lockout.MaxFailedAccessAttempts = 3;
                cfg.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 3, 0);

                cfg.SignIn.RequireConfirmedEmail = true;
            });

            services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/accessdenied.html";

                cfg.ExpireTimeSpan = new TimeSpan(0, 5, 0);
                cfg.Cookie.Name = "CvTemplate";
            });

            services.AddAuthentication(); 


            services.AddAuthorization(cfg =>
            {
                foreach (var item in Extension.principals)
                {
                    cfg.AddPolicy(item, p =>
                    {
                        p.RequireAssertion(h =>
                        {
                            return h.User.IsInRole("SuperAdmin") ||
                            h.User.HasClaim(item, "1");
                        });
                    });
                }

            });

            var asmbls = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("CvTemplate."))
                .ToArray();
            services.AddMediatR(asmbls);

        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.Seed();
            }

            app.UseStaticFiles();

            app.SeedMembership();


            app.UseRouting();

            app.UseRequestLocalization(cfg => {

                cfg.AddSupportedUICultures("az", "en");
                cfg.AddSupportedCultures("az", "en");

                cfg.RequestCultureProviders.Clear();
                cfg.RequestCultureProviders.Add(new CultureProvider());
            });

            app.Use(async (context, next) =>
            {
                if (!context.User.Identity.IsAuthenticated
                && !context.Request.Cookies.ContainsKey("cvtemplate")
                && context.Request.RouteValues.TryGetValue("area", out object areaName)
                && areaName.ToString().ToLower().Equals("admin"))
                {
                    var attr = context.GetEndpoint().Metadata.GetMetadata<AllowAnonymousAttribute>();
                    if (attr == null)
                    {
                        context.Response.Redirect("/admin/signin.html");
                        await context.Response.CompleteAsync();
                    }

                }
                await next();
            });

            app.UseAudit();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin_signIn", "admin/signin.html",
                    defaults: new
                    {
                        controller = "Account",
                        action = "Login",
                        area = "Admin"
                    });

                endpoints.MapControllerRoute("default_signIn", "signin.html",
                    defaults: new
                    {
                        controller = "Account",
                        action = "SignIn",
                        area = ""
                    });

                endpoints.MapControllerRoute("admin_signOut", "admin/logout.html",
                    defaults: new
                    {
                        controller = "Account",
                        action = "Logout",
                        area = "Admin"
                    });

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
