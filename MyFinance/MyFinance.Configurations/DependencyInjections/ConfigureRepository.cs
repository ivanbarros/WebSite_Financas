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

            services.AddScoped(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountPlanRepository, AccountPlanRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICashFlowRepository, CashFlowRepository>();
            services.AddScoped<ICashFlowTypeEnumRepository, CashFlowTypeEnumRepository>();
            services.AddScoped<ICategoryEnumRepository, CategoryEnumRepository>();
            services.AddScoped<ICalendarEventRepository, CalendarEventRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IDevolutionRepository, DevolutionRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IExtractRepository, ExtractRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped<ISalesRepository, SalesRepository>();
            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ITypeContractRepository, TypeContractRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
