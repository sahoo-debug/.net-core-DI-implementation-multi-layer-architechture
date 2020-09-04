using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DI.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.Scan(scan => scan
            //    .FromAssemblyOf<Startup>()    //.FromCallingAssembly()
            //        .AddClasses(classes => classes.Where(t => t.Name.EndsWith("repository", StringComparison.OrdinalIgnoreCase)))
            //        .AsImplementedInterfaces()
            //        .WithTransientLifetime()
            //    );


            var assembly = System.Reflection.Assembly.LoadFrom(@"bin\Debug\netcoreapp3.1\DI.Services.dll");
            services.Scan(scan => scan
                 .FromAssemblyDependencies(assembly)
                 .AddClasses(true) //.AddClasses(classes => classes.Where(t => t.Name.EndsWith("Service", StringComparison.OrdinalIgnoreCase)))
                 .AsImplementedInterfaces()
                 .WithTransientLifetime()
            );

            var assembly1 = System.Reflection.Assembly.LoadFrom(@"bin\Debug\netcoreapp3.1\DI.Core.Repository.dll");
            services.Scan(scan => scan
                 .FromAssemblyDependencies(assembly1)
                 .AddClasses(true)
                 .AsImplementedInterfaces()
                 .WithTransientLifetime()
            );


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
