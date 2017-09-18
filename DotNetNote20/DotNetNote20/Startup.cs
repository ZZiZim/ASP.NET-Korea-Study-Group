using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DotNetNote20.Services;
using DotNetNote20.Settings;
using DotNetNote20.Models;

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

            // [!] Configuration: JSON 파일의 데이터를 POCO 클래스에 주입
            services.Configure<DotNetNoteSettings>(
            Configuration.GetSection("DotNetNoteSettings"));

            // [DNN][!] Configuration 개체 주입:
            //    IConfiguration 또는 IConfigurationRoot에 Configuration 개체 전달
            //    appsettings.json 파일의 데이터베이스 연결 문자열을
            //    리파지터리 클래스에서 사용할 수 있도록 설정
            services.AddSingleton<IConfiguration>(Configuration);

            //[Tech] 기술 목록
            services.AddTransient<ITechRepository, TechRepository>();
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