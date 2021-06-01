using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Services;
using SmartPhone.Models.ViewModel;
using Microsoft.Extensions.Hosting;
using Rotativa.AspNetCore;

namespace SmartPhone.Web
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
            services.AddControllersWithViews();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllers();
            services.AddMemoryCache();

            services.AddDistributedMemoryCache();
            //// Thêm  dịch vụ Session, dịch vụ này cunng cấp Middleware:
            services.AddSession(cfg =>
            {                    // Đăng ký dịch vụ Session
                cfg.Cookie.Name = "lanhang";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(0, 30, 0);
            });
            services.AddHttpContextAccessor();
            services.AddServerSideBlazor();

            services.AddHttpClient();

            services.AddOptions();
            var mailsettings = Configuration.GetSection("MailSettings");  // đọc config
            services.Configure<MailSettings>(mailsettings);
            //register service
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IBannerService, BannerService>();
            services.AddTransient<ICategoryProductService, CategoryProductService>();
            services.AddTransient<IConfigService, ConfigService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IFooterService, FooterService>();
            services.AddTransient<IMasterDataService, MasterDataService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<INewService, NewService>();
            services.AddTransient<IPageImageService, PageImageService>();
            services.AddTransient<IPolicyService, PolicyService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductSpecificationService, ProductSpecificationService>();
            services.AddTransient<IBannerService, BannerService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IBannerService, BannerService>();

            services.AddTransient<ISendMailService, SendMailService>();




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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            RotativaConfiguration.Setup(env.WebRootPath , "Rotativa");


        }
       
    }

}
