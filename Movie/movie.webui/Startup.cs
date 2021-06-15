using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie.webui.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using movie.data.Abstract;
using movie.data.Concrete;


namespace movie.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=movieDb")); //identity tablolarını veritabanına kaydediyoruz.
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();  //token providers ekleme sebibi parola yenileme falan için. Benzersiz sayı.

            services.Configure<IdentityOptions>(options =>
            {  //5 kere yanlış girme hakkım olsun.
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/home/index";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(365);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".MehmetOzturk"
                };
            });


            services.AddScoped<IAbout, AboutRepository>();
            services.AddScoped<IMovie, MovieRepository>();
            services.AddScoped<IDirector, DirectorRepository>();
            services.AddScoped<IAwards, AwardsRepository>();
            services.AddScoped<IActor, ActorRepository>();


            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseAuthentication(); //Identity servisini ekledik.
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}"
               );
                endpoints.MapControllerRoute(
                   name: "directordetails",
                   pattern: "home/details",
                   defaults: new { controller = "Home", action = "details" }
               );
                endpoints.MapControllerRoute(
                  name: "admin",
                  pattern: "admin/index",
                  defaults: new { controller = "admin", action = "index" }
              );
            });
            SeedIdentity.Seed(userManager, roleManager, configuration).Wait();

        }
    }
}
