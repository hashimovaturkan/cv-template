using CvTemplate.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Core.Providers
{
    public class AppClaimProvider : IClaimsTransformation
    {
        readonly CvTemplateDbContext db;
        public AppClaimProvider(CvTemplateDbContext db)
        {
            this.db = db;
        }

        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (principal.Identity.IsAuthenticated 
                && principal.Identity is ClaimsIdentity cIdentity) 
            {
                while (cIdentity.Claims.Any(c => !c.Type.StartsWith("http") && !c.Type.StartsWith("Asp"))) 
                {
                    var claims = cIdentity.Claims.First(c => !c.Type.StartsWith("http") && !c.Type.StartsWith("Asp"));
                    cIdentity.RemoveClaim(claims);  

                }

                var userId = Convert.ToInt32(cIdentity.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier))?.Value);
                var claimNames = new List<string>();  

                
                string[] lst = db.UserClaims.Where(c => c.UserId == userId && c.ClaimValue.Equals("1")).Select(c => c.ClaimType).ToArray();
                claimNames.AddRange(lst);

                
                string[] rClaims = (from ur in db.UserRoles
                                    join rc in db.RoleClaims on ur.RoleId equals rc.RoleId
                                    where ur.UserId == userId && rc.ClaimValue.Equals("1")
                                    select rc.ClaimType).ToArray();
                claimNames.AddRange(rClaims);


                
                foreach (var item in claimNames)
                {
                    cIdentity.AddClaim(new Claim(item, "1"));
                }

            }

            return principal;
        }
    }
}
