using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DotNetNote20.Services;

namespace DotNetNote20
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
            services.AddMvc();

            //[Demo] DemoFinder 의존성 주입
            services.AddTransient<DotNetNote20.Models.DataFinder>();

            ////[DI] InfoService 클래스 의존성 주입
            services.AddSingleton<InfoService>();
            services.AddSingleton<IInfoService, InfoService>();
            //[DI(Dependency Injection)] 서비스 등록
            services.AddScoped<ICopyrightService, CopyrightService>();
            //[DI] @inject 키워드로 뷰에 직접 클래스의 속성 또는 메서드 값 출력
            services.AddSingleton<CopyrightService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}