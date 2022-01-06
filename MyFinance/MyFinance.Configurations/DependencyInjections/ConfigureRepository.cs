using Microsoft.Extensions.DependencyInjection;
using MyFinance.Repository;
using MyFinance.Repository.Interfaces.Repositories;

namespace MyFinance.Configurations.DependencyInjections
{
    public static class ConfigureRepository
    {

        public static void ConfigureDependenciesRepositories(this IServiceCollection services)
        {

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IContaRepository, ContaRepository>();
            //services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddScoped<IWaiterRepository, WaiterRepository>();
            //services.AddScoped<ILogRepository, LogRepository>();

        }
    }
}
