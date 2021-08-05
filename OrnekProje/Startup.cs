using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace OrnekProje
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) //Bu uygulamada kullanýlacak servislerin konfigure edildiði alandýr.
        {
            services.AddControllersWithViews();  //MVC servisini ekleyelim. Böylelikle uygulama MVC yapýlanmasý ile çalýþacaðýný biliyor. 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // Burada uygulamada kullanýlacak middleware/arakatman/ara yazýlýmlarý caðýrdýðýmýz alandýr.
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //Pipeline da roota giren alan burda belirlenir. gelen isteði(requestin) rotasý bu middleware sayesinde belirleniyor.

            app.UseEndpoints(endpoints => //endpoint ise yapýlan isteðin(url nin) istek adresinn belirlendiði alnadýr. uygulamaya gelen isteklerin hangi rotalar/þablonlar eþliðinde gelebileceði burad bildiriliyor.
            {
                /* endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World!");
                 }); */

                endpoints.MapDefaultControllerRoute(); //{controller= Home} /{action = Index}/{id?} default olan endpoint þemasýdýr.Orn: https://www...com/yetkinlikler/getir
                //endpoint içerisinde süslü parantezler içerisine parametre tanýmlanabilir. Home, Index gibi
            });
        }
    }
}
