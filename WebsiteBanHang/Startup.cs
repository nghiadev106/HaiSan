using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebsiteBanHang.Data;
using WebsiteBanHang.Services;

namespace WebsiteBanHang
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
            services.AddDbContextPool<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContextPool<HaiSanContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //   .AddCookie(options =>
            //   {
            //       options.LoginPath = "/Admin/User/Login";
            //       options.AccessDeniedPath = "/User/Forbidden/";
            //   });

            services.AddTransient<IStorageService, FileStorageService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService,CategoryService>();
            services.AddTransient<INewsService, NewsService>();
            services.AddTransient<ICategoryNewsService, CategoryNewsService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ISlideService, SlideService>();
            services.AddTransient<IPromotionService, PromotionService>();
            services.AddTransient<ITopMenuService, TopMenuService>();

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(100);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddControllersWithViews();
            IMvcBuilder builder = services.AddRazorPages();
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

#if DEBUG
            if (environment == Environments.Development)
            {
                builder.AddRazorRuntimeCompilation();
            }
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();     
            
            app.UseAuthorization();

            app.UseSession();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
               name: "admin",
               pattern: "admin", new
               {
                   area = "Admin",
                   controller = "User",
                   action = "Login"
               });

                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                name: "Cart",
                pattern: "gio-hang", new
                {
                    controller = "Cart",
                    action = "Index"
                });

                endpoints.MapControllerRoute(
               name: "SearchAdvand",
               pattern: "tim-kiem-chi-tiet", new
               {
                   controller = "Products",
                   action = "SearchAdvand"
               });

                endpoints.MapControllerRoute(
               name: "Search",
               pattern: "tim-kiem", new
               {
                   controller = "Products",
                   action = "Search"
               });

                endpoints.MapControllerRoute(
                 name: "ProductCategories",
                 pattern: "chuyen-muc/{url}/{id}",
                 defaults: new { controller = "Home", action = "ProductCategories" }
                 );

                endpoints.MapControllerRoute(
               name: "ProductCategories",
               pattern: "loai-tin/{url}/{id}",
               defaults: new { controller = "News", action = "Category" }
               );

                endpoints.MapControllerRoute(
                  name: "ProductCategories",
                  pattern: "tin-tuc",
                  defaults: new { controller = "News", action = "Index" }
                  );

                endpoints.MapControllerRoute(
                name: "Product Detail",
                pattern: "san-pham/{url}/{id}", new
                {
                    controller = "Products",
                    action = "DetailProduct"
                });

                endpoints.MapControllerRoute(
                 name: "News Detail",
                 pattern: "tin-tuc/{url}/{id}", new
                 {
                     controller = "News",
                     action = "Detail"
                 });

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
