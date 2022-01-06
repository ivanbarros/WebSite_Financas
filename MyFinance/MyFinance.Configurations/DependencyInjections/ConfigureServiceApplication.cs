using Microsoft.Extensions.DependencyInjection;

namespace MyFinance.Configurations.DependencyInjections
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
