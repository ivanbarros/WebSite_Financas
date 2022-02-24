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
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountPlanRepository, AccountPlanRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<ICashFlowRepository, CashFlowRepository>();
            services.AddTransient<ICashFlowTypeEnumRepository, CashFlowTypeEnumRepository>();
            services.AddTransient<ICategoryEnumRepository, CategoryEnumRepository>();
            services.AddTransient<ICalendarEventRepository, CalendarEventRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IDevolutionRepository, DevolutionRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IExtractRepository, ExtractRepository>();
            services.AddTransient<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddTransient<IPermissionRepository, PermissionRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductTypeRepository, ProductTypeRepository>();
            services.AddTransient<ISalesRepository, SalesRepository>();
            services.AddTransient<IStockRepository, StockRepository>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.AddTransient<ITypeContractRepository, TypeContractRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

        }
    }
}
