using Microsoft.Extensions.DependencyInjection;
using MyFinance.Domain.UnitOfWorkConfig;
using MyFinance.Domain.UnitOfWorkConfig.Interface;
using MyFinance.Service;
using MyFinance.Service.Interfaces;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Configurations.DependencyInjections
{
    public static class ConfigureService
    {
        public static void ConfigureDependenciesService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IContaService, ContaService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICashFlowService, CashFlowService>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IWaiterService, WaiterService>();
            //services.AddScoped<IOneSignalService, OneSignalService>();
        }
    }
}
