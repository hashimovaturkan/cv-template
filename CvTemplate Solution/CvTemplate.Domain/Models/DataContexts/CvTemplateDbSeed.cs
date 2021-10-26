using CvTemplate.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.DataContexts
{
    public static class RiodeDbSeed
    {
        public static IApplicationBuilder SeedMembership(this IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {


                var role = new CvTemplateRole
                {
                    Name = "SuperAdmin"
                };

                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<CvTemplateUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<CvTemplateRole>>();

                bool hasRole = roleManager.RoleExistsAsync(role.Name).Result;  
                if (hasRole == true) 
                {
                    role = roleManager.FindByNameAsync(role.Name).Result;  
                }
                else 
                {
                    var iResult = roleManager.CreateAsync(role).Result; 
                    if (!iResult.Succeeded)         
                        goto end;
                }

                string password = "123";

                var user = new CvTemplateUser
                {
                    UserName = "Turkan",
                    Email = "turkan@mail.ru",
                    EmailConfirmed = true

                };

                var founded = userManager.FindByEmailAsync(user.Email).Result;  

                if (founded != null && !userManager.IsInRoleAsync(founded, role.Name).Result)  
                {
                    userManager.AddToRoleAsync(founded, role.Name).Wait();   
                }
                else if (founded == null)  
                {
                    var iUserResult = userManager.CreateAsync(user, password).Result; 

                    if (iUserResult.Succeeded) 
                    {
                        userManager.AddToRoleAsync(user, role.Name).Wait();  
                    }
                    else
                    {
                        goto end;
                    }
                }
            }

        end:
            return builder;
        }

        public static IApplicationBuilder Seed(this IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CvTemplateDbContext>();
                db.Database.Migrate();

            }
            return builder;
        }
    }
}
