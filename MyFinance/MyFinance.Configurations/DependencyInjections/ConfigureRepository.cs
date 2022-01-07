using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Domain.UnitOfWorkConfig;
using MyFinance.Domain.UnitOfWorkConfig.Interface;
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

            services.AddTransient(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IContaRepository, ContaRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            //services.AddScoped<IWaiterRepository, WaiterRepository>();
            //services.AddScoped<ILogRepository, LogRepository>();

        }
    }
}
