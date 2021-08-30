using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthCareERP.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HealthCareERP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = new InitService();
            obj.MigrateAnvisaSheet();
            // CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
