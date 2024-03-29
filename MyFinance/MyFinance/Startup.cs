﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Configurations;
using MyFinance.Configurations.DataBaseConfigs;
using MyFinance.Configurations.DependencyInjections;
using MyFinance.Data.Context;
using ReflectionIT.Mvc.Paging;
using System;

namespace MyFinance
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
            
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            MigratorServices.CreateService(Configuration["sqlDb:connectionString"]);            
            ConfigureService.ConfigureDependenciesService(services);
            ConfigureServiceApplication.ConfigureDependenciesServiceAppication(services);
            ConfigureRepository.ConfigureDependenciesRepositories(services);
            var connection = Configuration["sqlDb:connectionString"];
            
            services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
            
            services.AddSqlDatabase(Configuration);
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(300);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.HttpOnly = true;
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // Adicione eessa linha para que seu projeto volte a funcionar normalmente.
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSession();
            services.AddPaging(options => {
                options.ViewName = "Bootstrap4";
                options.PageParameterName = "pageindex";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
