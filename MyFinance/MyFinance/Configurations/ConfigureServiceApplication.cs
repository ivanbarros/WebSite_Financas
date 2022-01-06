using Microsoft.Extensions.DependencyInjection;
using MyFinance.Interfaces;
using MyFinance.Interfaces.Services;
using MyFinance.ServicesApplication;

namespace MyFinance.Configurations
{
    public static class ConfigureServiceApplication
    {
        public static void ConfigureDependenciesServiceAppication(this IServiceCollection services)
        {
            services.AddScoped<IUserServiceApplication, UserServiceApplication>();
            services.AddScoped<IContaServiceApplication, ContaServiceApplication>();
            //services.AddScoped<IFoodService, FoodService>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IWaiterService, WaiterService>();
            //services.AddScoped<IOneSignalService, OneSignalService>();
        }
    }
}
