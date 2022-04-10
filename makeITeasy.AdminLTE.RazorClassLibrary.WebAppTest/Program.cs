using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (System.Exception exception)
            {
                string errorMessage = exception.Message;
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
