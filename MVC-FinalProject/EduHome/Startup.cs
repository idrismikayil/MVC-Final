using EduHome.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        public Startup(IConfiguration configuration/*, IWebHostEnvironment env*/)
        {
            Configuration = configuration;
            //_env = env;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddIdentity<User, IdentityRole>(options =>
            //{
            //    options.Password.RequiredLength = 5;
            //    options.User.RequireUniqueEmail = true;
            //    options.SignIn.RequireConfirmedEmail = true;
            //    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);

            //}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            //services.AddScoped<IMailService, MailService>();

            services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>(option => {
                option.UseSqlServer(Configuration.GetConnectionString("Default"));
            });

            //FileConstants.ImagePath = Path.Combine(_env.WebRootPath, "assets", "images");

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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name: "areas",
                //    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                //  );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
