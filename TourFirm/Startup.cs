using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.DataBase;
using TourFirm.Services;
using TourFirm.Services.CountyCities;
using Microsoft.AspNetCore.Identity;
using TourFirm.Models.Identity;

namespace TourFirm
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

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowAll", p =>
            //    {
            //        p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            //    });
            //});
            
            services.AddControllersWithViews().AddRazorRuntimeCompilation()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddDbContext<TourFirmDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ContextUsers>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("UsersIdentityConnection")));

            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.Password.RequireNonAlphanumeric = false;
                opts.User.RequireUniqueEmail = true;    // уникальный email
                opts.User.AllowedUserNameCharacters = ".@abcdefghijklmnopqrstuvwxyz"; // допустимые символы
            })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ContextUsers>();


            

            services.AddScoped<ITourService, TourService>();
            services.AddScoped<ICountryCitiesService, CountryCitiesService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            //app.UseCors("AllowAll");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            

            app.UseRouting();

            //app.UseCors(builder => builder.AllowAnyOrigin());

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapControllerRoute(
                //    name: "api",
                //    pattern: "api/{controller=Payment}/{action=test}/{id?}");
            });


        }
    }
}
