using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OrnekProje
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); //Kestrel/ISS gibi sunucusunu ayaga kaldýrýyor.
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseUrls("http://*.1000");
                    webBuilder.UseStartup<Startup>(); //Startup sýnýfýndaki konfigurasyon ile ayaga kalkýyor.
                });
    }
}
