using Microsoft.EntityFrameworkCore;
using ManagementSystem.Infrastructure.Data.Migrations;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementSystem.Infrastructure.Data
{
    public static class RegistrationExtensions
    {
        public static void AddStorage(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<CrmDbContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString:LocalDbSqlServer"]);

            });
        }

        //public static IServiceCollection AddDataService(this IServiceCollection services, string connectionString)
        //{
        //    services.AddDbContext<CrmDbContext>(options =>
        //    {
        //        options.UseSqlServer(connectionString);

        //    });

        //    return services;
        //}
    }
}
