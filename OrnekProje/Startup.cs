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
        public void ConfigureServices(IServiceCollection services) //Bu uygulamada kullan�lacak servislerin konfigure edildi�i aland�r.
        {
            services.AddControllersWithViews();  //MVC servisini ekleyelim. B�ylelikle uygulama MVC yap�lanmas� ile �al��aca��n� biliyor. 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // Burada uygulamada kullan�lacak middleware/arakatman/ara yaz�l�mlar� ca��rd���m�z aland�r.
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //Pipeline da roota giren alan burda belirlenir. gelen iste�i(requestin) rotas� bu middleware sayesinde belirleniyor.

            app.UseEndpoints(endpoints => //endpoint ise yap�lan iste�in(url nin) istek adresinn belirlendi�i alnad�r. uygulamaya gelen isteklerin hangi rotalar/�ablonlar e�li�inde gelebilece�i burad bildiriliyor.
            {
                /* endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World!");
                 }); */

                endpoints.MapDefaultControllerRoute(); //{controller= Home} /{action = Index}/{id?} default olan endpoint �emas�d�r.Orn: https://www...com/yetkinlikler/getir
                //endpoint i�erisinde s�sl� parantezler i�erisine parametre tan�mlanabilir. Home, Index gibi
            });
        }
    }
}
