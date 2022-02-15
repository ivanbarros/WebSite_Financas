using Microsoft.Extensions.DependencyInjection;
using MyFinance.Interfaces.Services;
using MyFinance.Interfaces.Services.InterfaceBase;
using MyFinance.ServicesApplication;

namespace MyFinance.Configurations
{
    public static class ConfigureServiceApplication
    {
        public static void ConfigureDependenciesServiceAppication(this IServiceCollection services)
        {
            services.AddScoped<IUserServiceApplication, UserServiceApplication>();
            services.AddScoped<IAccountServiceApplication, AccountServiceApplication>();
            services.AddScoped<ICashFlowServiceApplication, CashFlowServiceApplication>();
            services.AddScoped<ICalendarEventServiceApplication, CalendarEventServiceApplication>();
            services.AddScoped<IExtractServiceApplication, ExtractServiceApplication>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IWaiterService, WaiterService>();
            //services.AddScoped<IOneSignalService, OneSignalService>();
        }
    }
}
