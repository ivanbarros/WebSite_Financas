using Microsoft.Extensions.DependencyInjection;
using MyFinance.Domain.UnitOfWorkConfig;
using MyFinance.Domain.UnitOfWorkConfig.Interface;
using MyFinance.Service;
using MyFinance.Service.Interfaces.Services;

namespace MyFinance.Configurations.DependencyInjections
{
    public static class ConfigureService
    {
        public static void ConfigureDependenciesService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICashFlowService, CashFlowService>();
            services.AddScoped<ICalendarEventService, CalendarEventService>();
            services.AddScoped<IExtractService, ExtractService>();
            services.AddScoped<IAccountPlanService, AccountPlanService>();
        }
    }
}
