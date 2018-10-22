using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Models;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Abstract;
using ShoppingCart.Concrete;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ShoppingCart
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
            services.AddSingleton<IFileProvider>(
               new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));

            services.AddTransient<IItemCategoryData, ItemCategoryData>();
            services.AddTransient<IItemData, ItemData>();
            services.AddTransient<IShopData, ShopData>();
            services.AddTransient<IAdminData, AdminData>();
            services.AddTransient<ILoginData, LoginData>();
            services.AddTransient<ICartData, CartData>();
            services.AddTransient<IUserData, UserData>();
            services.AddTransient<IOrderData, OrderData>();

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ShoppingCartDbContext>().AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(options => options.LoginPath = "/Administration/Login/Login");
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped(sp => Cart.GetCart(sp));

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => { options.LoginPath = "/Login"; });
            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizeFolder("/");
                options.Conventions.AllowAnonymousToPage("/Login");
            });

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
            var connection = @"Server=CJ\SQLEXPRESS;Database=ShoppingCartDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<ShoppingCartDbContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            
            loggerFactory.AddConsole();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseDirectoryBrowser(new DirectoryBrowserOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "shopImages")),
                RequestPath = new PathString("/shopImages")
            });
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{area=Administration}/{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
