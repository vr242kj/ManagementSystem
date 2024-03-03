using Microsoft.EntityFrameworkCore;
using ManagementSystem.Infrastructure.Data.Migrations;

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
    }
}
