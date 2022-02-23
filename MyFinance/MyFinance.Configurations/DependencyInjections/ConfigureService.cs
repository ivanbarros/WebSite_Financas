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
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAccountPlanService, AccountPlanService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICalendarEventService, CalendarEventService>();
            services.AddScoped<ICashFlowService, CashFlowService>();
            services.AddScoped<ICashFlowTypeEnumService, CashFlowTypeEnumService>();
            services.AddScoped<ICategoryEnumService, CategoryEnumService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IDevolutionService, DevolutionService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IExtractService, ExtractService>();
            services.AddScoped<IPaymentMethodService, PaymentMethodService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<ISalesService, SalesService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ITypeContractService, TypeContractService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();

            //services.AddScoped<IOneSignalService, OneSignalService>();
        }
    }
}
