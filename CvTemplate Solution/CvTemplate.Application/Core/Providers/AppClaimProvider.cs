using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
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
                var userId = Convert.ToInt32(cIdentity.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier))?.Value);
                var user = await db.Users.FirstOrDefaultAsync(c => c.Id == userId);

                if (user != null)
                {
                    cIdentity.AddClaim(new Claim("username", user.UserName));
                }

                var role = cIdentity.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Role));
                if (role != null)
                {
                    cIdentity.RemoveClaim(role);
                    role = cIdentity.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Role));
                }

                var rClaims = (from ur in db.UserRoles
                               join r in db.Roles on ur.RoleId equals r.Id
                               where ur.UserId == userId
                               select r.Name).ToArray();

                foreach (var item in rClaims)
                {
                    cIdentity.AddClaim(new Claim(ClaimTypes.Role, item));
                }

                var currentClaims = cIdentity.Claims.Where(c=> Extension.principals.Contains(c.Type)).ToArray();

                foreach (var claim in currentClaims)
                {
                    cIdentity.RemoveClaim(claim);
                }

                var currentPolicies = await (from uc in db.UserClaims
                                where uc.UserId == userId && uc.ClaimValue =="1"
                                select uc.ClaimType)
                                .Union(from rc in db.RoleClaims
                                       join ur in db.UserRoles on rc.RoleId equals ur.RoleId
                                       where ur.UserId == userId && rc.ClaimValue.Equals("1")
                                       select rc.ClaimType).ToListAsync();

                foreach (var item in currentPolicies)
                {
                    cIdentity.AddClaim(new Claim(item, "1"));
                }
            }

            return principal;
        }
    }
}
