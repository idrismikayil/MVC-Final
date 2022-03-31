using EduHome.Constants;
using EduHome.DAL;
using EduHome.Models;
using EduHome.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 5;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);

            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            services.AddScoped<IMailService, MailService>();

            services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>(option => {
                option.UseSqlServer(Configuration.GetConnectionString("Default"));
            });

            FileConstants.ImagePath = Path.Combine(_env.WebRootPath, "assets", "img");
            FileConstants.ImagePathAbout = Path.Combine(_env.WebRootPath, "assets", "img", "about");
            FileConstants.ImagePathBanner = Path.Combine(_env.WebRootPath, "assets", "img", "banner");
            FileConstants.ImagePathBlog = Path.Combine(_env.WebRootPath, "assets", "img", "blog");
            FileConstants.ImagePathChoose = Path.Combine(_env.WebRootPath, "assets", "img", "choose");
            FileConstants.ImagePathContact = Path.Combine(_env.WebRootPath, "assets", "img", "contact");
            FileConstants.ImagePathCourse = Path.Combine(_env.WebRootPath, "assets", "img", "course");
            FileConstants.ImagePathEvent = Path.Combine(_env.WebRootPath, "assets", "img", "event");
            FileConstants.ImagePathFooter = Path.Combine(_env.WebRootPath, "assets", "img", "footer");
            FileConstants.ImagePathIcon = Path.Combine(_env.WebRootPath, "assets", "img", "icon");
            FileConstants.ImagePathLogo = Path.Combine(_env.WebRootPath, "assets", "img", "logo");
            FileConstants.ImagePathNotice = Path.Combine(_env.WebRootPath, "assets", "img", "notice");
            FileConstants.ImagePathPost = Path.Combine(_env.WebRootPath, "assets", "img", "post");
            FileConstants.ImagePathSlider = Path.Combine(_env.WebRootPath, "assets", "img", "slider");
            FileConstants.ImagePathTeacher = Path.Combine(_env.WebRootPath, "assets", "img", "teacher");
            FileConstants.ImagePathTestimonial = Path.Combine(_env.WebRootPath, "assets", "img", "testimonial");
        }

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
            //app.UseSession();d
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                  );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
