using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Core.Middlewares
{
    public class AuditMiddleware
    {
        private readonly RequestDelegate _next;

        public AuditMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            using (var scope = httpContext.RequestServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CvTemplateDbContext>();

                var routeData = httpContext.GetRouteData();

                var log = new AuditLog();
                log.CreatedDate = log.RequestTime = DateTime.Now;
                log.IsHttps = httpContext.Request.IsHttps;
                log.Method = httpContext.Request.Method;
                log.Path = httpContext.Request.Path;

                if (routeData.Values.TryGetValue("area", out object area))
                {
                    log.Area = area.ToString();
                }

                if (routeData.Values.TryGetValue("controller", out object controller))
                {
                    log.Controller = controller.ToString();
                }

                if (routeData.Values.TryGetValue("action", out object action))
                {
                    log.Action = action.ToString();
                }

                if (!string.IsNullOrWhiteSpace(httpContext.Request.QueryString.Value))
                {
                    log.QueryString = httpContext.Request.QueryString.Value;
                }


                await _next(httpContext);


                log.StatusCode = httpContext.Response.StatusCode;
                log.ResponseTime = DateTime.Now;

                db.AuditLogs.Add(log);
                db.SaveChanges();
            }


        }
    }

    public static class AuditMiddlewareExtensions
    {
        public static IApplicationBuilder UseAudit(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuditMiddleware>();
        }
    }
}
