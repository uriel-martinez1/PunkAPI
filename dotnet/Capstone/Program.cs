using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace Capstone
{
    public class Program
    {
        // api string that is specific for returning a specific beer
        private const string ApiURL = "https://api.punkapi.com/v2/beers/1";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

