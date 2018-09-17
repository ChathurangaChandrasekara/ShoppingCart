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
            services.AddMvc();
            var connection = @"Server=CJ\SQLEXPRESS;Database=ShoppingCartDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<ShoppingCartDbContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            app.UseStaticFiles();

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
