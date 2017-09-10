using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace EntApp2{

    public class Startup
    {
        public void Configure(IApplicationBuilder app){


            //app.UseMvc();
            app.UseMvc(routes => 
            {
                        routes.MapRoute(
                            name: "default",
                            template: "{controller=Home}/{action=Index}/{id?}");
            });


        
            app.Run(context => {
                return context.Response.WriteAsync("ttt");
            });
        }

        //public void ConfigureServices(IserviceCollection)




    }


}