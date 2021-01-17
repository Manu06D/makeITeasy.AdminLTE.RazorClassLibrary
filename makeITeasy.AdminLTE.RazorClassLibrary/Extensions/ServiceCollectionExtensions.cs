using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using makeITeasy.AdminLTE.RazorClassLibrary.Attributes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace makeITeasy.AdminLTE.RazorClassLibrary.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void DiscoverWebSitePage(this IServiceCollection services, Assembly assembly)
        {
            var linkGenerator = services.BuildServiceProvider().GetRequiredService<LinkGenerator>();

            List<MethodInfo> actions = assembly.GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type))
                .SelectMany(type => type.GetMethods())
                .Where(method => method.IsPublic && method.IsDefined(typeof(WebSitePageAttribute))).ToList();

            foreach(MethodInfo mi in actions)
            {
                //Type m = ((Controller)mi.DeclaringType);
                string s = linkGenerator.GetPathByAction(mi.Name, string.Empty);
            }
        }

        public static void SetUpWebSite(this IApplicationBuilder app, Assembly assembly)
        {

            var appPart = app.ApplicationServices.GetService<ApplicationPartManager>();

            var linkGenerator =  app.ApplicationServices.GetService<LinkGenerator>();

            List<MethodInfo> actions = assembly.GetTypes()
    .Where(type => typeof(Controller).IsAssignableFrom(type))
    .SelectMany(type => type.GetMethods())
    .Where(method => method.IsPublic && method.IsDefined(typeof(WebSitePageAttribute))).ToList();

            foreach (MethodInfo mi in actions)
            {
                //Type m = ((Controller)mi.DeclaringType);

            }
        }
    }
}
