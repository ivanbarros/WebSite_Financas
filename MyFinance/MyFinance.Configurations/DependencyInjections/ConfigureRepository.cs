﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Repository;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service;
using MyFinance.Service.Interfaces;

namespace MyFinance.Configurations.DependencyInjections
{
    public static class ConfigureRepository
    {

        public static void ConfigureDependenciesRepositories(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IContaRepository, ContaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            //services.AddScoped<IWaiterRepository, WaiterRepository>();
            //services.AddScoped<ILogRepository, LogRepository>();

        }
    }
}