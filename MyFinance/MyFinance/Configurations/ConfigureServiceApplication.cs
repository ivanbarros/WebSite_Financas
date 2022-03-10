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
            services.AddScoped<IAccountPlanServiceApplication, AccountPlanServiceApplication>();
            services.AddScoped<IAddressServiceApplication, AddressServiceApplication>();
            services.AddScoped<ICalendarEventServiceApplication, CalendarEventServiceApplication>();
            services.AddScoped<ICashFlowServiceApplication, CashFlowServiceApplication>();
            services.AddScoped<ICashFlowTypeEnumServiceApplication, CashFlowTypeEnumServiceApplication>();
            services.AddScoped<ICategoryEnumServiceApplication, CategoryEnumServiceApplication>();
            services.AddScoped<ICustomerServiceApplication, CustomerServiceApplication>();
            services.AddScoped<IDevolutionServiceApplication, DevolutionServiceApplication>();
            services.AddScoped<IEmployeeServiceApplication, EmployeeServiceApplication>();
            services.AddScoped<IExtractServiceApplication, ExtractServiceApplication>();
            services.AddScoped<IPaymentMethodServiceApplication, PaymentMethodServiceApplication>();
            services.AddScoped<IPermissionServiceApplication, PermissionServiceApplication>();
            services.AddScoped<IProductServiceApplication, ProductServiceApplication>();
            services.AddScoped<IProductTypeServiceApplication, ProductTypeServiceApplication>();
            services.AddScoped<ISalesServiceApplication, SalesServiceApplication>();
            services.AddScoped<IStockServiceApplication, StockServiceApplication>();
            services.AddScoped<ISupplierServiceApplication, SupplierServiceApplication>();
            services.AddScoped<ITypeContractServiceApplication, TypeContractServiceApplication>();
            
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IWaiterService, WaiterService>();
            //services.AddScoped<IOneSignalService, OneSignalService>();
        }
    }
}
