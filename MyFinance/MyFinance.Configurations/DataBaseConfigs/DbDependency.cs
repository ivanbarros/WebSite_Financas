using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Configurations.DependencyInjections;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Configurations.DataBaseConfigs
{
    public static class DbDependency
    {
        public static void AddMySqlDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMySqlConfiguration(configuration);
            services.ConfigureDependenciesRepositories();
        }

        public static void AddSqlDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlConfiguration(configuration);
            services.ConfigureDependenciesRepositories();
        }
    }
}
