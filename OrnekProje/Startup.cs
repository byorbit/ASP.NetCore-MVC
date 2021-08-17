using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace OrnekProje
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) //Bu uygulamada kullanýlacak servislerin konfigure edildiði alandýr.
        {
            services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Startup>());  
            //MVC servisini ekleyelim. Böylelikle uygulama MVC yapýlanmasý ile çalýþacaðýný biliyor. 
            //Fluentvalidation paketini de ekledik.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // Burada uygulamada kullanýlacak middleware/arakatman/ara yazýlýmlarý caðýrdýðýmýz alandýr.
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // wwwroot klasorundeki kütüphaneleri kullanabilmek için 
            app.UseRouting(); //Pipeline da roota giren alan burda belirlenir. gelen isteði(requestin) rotasý bu middleware sayesinde belirleniyor.

            app.UseEndpoints(endpoints => //endpoint ise yapýlan isteðin(url nin) istek adresinn belirlendiði alnadýr. uygulamaya gelen isteklerin hangi rotalar/þablonlar eþliðinde gelebileceði burad bildiriliyor.
            {
                endpoints.MapDefaultControllerRoute(); //{controller= Home} /{action = Index}/{id?} default olan endpoint þemasýdýr.Orn: www.fatihmetin.com/yetkinlikler/getir
                //endpoint içerisinde süslü parantezler içerisine parametre tanýmlanabilir. Home, Index gibi

                endpoints.MapControllerRoute("CustomRoute", "{controller= Route}/ {action= CustomRouteData}/{a}/{ b}/{c}"); //Custom rota oluþturarak veri yakalama
            });
        }
    }
}
