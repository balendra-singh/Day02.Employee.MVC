using Day02.Employee.MVC.Core.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02.Employee.MVC.Web
{
    public class Startup
    {
        //configuration came from DI
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container. //ioc [Inversion of control [Dependency Injection]] container
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddControllersWithViews();

            string dbConnnection = Configuration.GetConnectionString("EmployeeDbConnection");

            services.AddDbContext<EmployeeDbContext>(options =>
                     options.UseMySql(dbConnnection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. [Middlewares in .net core] [shortcircuting]
        // sequential dependent
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             // req-> starts
             // response ends 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles(); //returned sucess / failure

            app.UseRouting();

            app.UseAuthorization();           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Employee}/{action=ManageEmployees}/{id?}");
            });
            //Req -> ends
            //response -> start
        }
    }
}
