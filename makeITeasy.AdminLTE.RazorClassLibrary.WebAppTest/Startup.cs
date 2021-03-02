using System.IO;
using System.Reflection;
using makeITeasy.AdminLTE.RazorClassLibrary.Extensions;
using makeITeasy.AdminLTE.RazorClassLibrary.Models;
using makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using SmartBreadcrumbs.Extensions;

namespace makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<PageDefinition>();
            services.AddSingleton<ISiteDefinition, WebAppSiteDefinition>();
            var builder = services.AddControllersWithViews();
            services.DiscoverWebSitePage(Assembly.GetExecutingAssembly());
            services.AddScoped<IUserInformation>((x) => new UserInformation()
            {
                Name = "Alexander Pierce",
                AvatarUrl = "/lib/admin-lte/img/user2-160x160.jpg"
            });

#if DEBUG
            if (_env.IsDevelopment())
            {
                string[] dirs = { Assembly.GetExecutingAssembly().GetName().Name, typeof(PageDefinition).Assembly.GetName().Name };
                builder.AddRazorRuntimeCompilation(options =>
                {
                    foreach (var dir in dirs)
                    {
                        var libraryPath = Path.GetFullPath(Path.Combine(_env.ContentRootPath, "..", dir));
                        options.FileProviders.Add(new PhysicalFileProvider(libraryPath));
                    }
                });
            }
#endif
            services.ConfigureWebSite(GetType().Assembly);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                //app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.SetUpWebSite(Assembly.GetExecutingAssembly());


        }
    }
}
