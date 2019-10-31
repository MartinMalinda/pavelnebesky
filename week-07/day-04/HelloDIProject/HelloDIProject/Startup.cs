using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace HelloDIProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ConsoleLoggerMiddleware>();
            services.AddTransient<Printer>();
            services.AddTransient<IColor, BlueColor>();
            services.AddTransient<UtilityService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMiddleware<ConsoleLoggerMiddleware>();
                app.UseMvc();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<a href=\"/useful/email?email=pavel@nebesky.eu\">check email pavel@nebesky.eu</a>");

            });
        }
    }
}
