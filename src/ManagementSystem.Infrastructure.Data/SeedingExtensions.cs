using ManagementSystem.Infrastructure.Data.Migrations;

namespace ManagementSystem.Infrastructure.Data
{
    public static class SeedingExtensions
    {
        public static async Task DatabaseEnsureCreated(this IApplicationBuilder applicationBuilder)
        {
            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<CrmDbContext>();
                var database = dbContext.Database;

                await database.EnsureDeletedAsync();
                await database.EnsureCreatedAsync();
            }
        }
    }
}
