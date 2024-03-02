using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Task = ManagementSystem.Core.Entities.Task;

namespace ManagementSystem.Infrastructure.Data.Migrations
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext(DbContextOptions options) : base(options) { }
        public CrmDbContext() { }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Comment> Comments  { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RecentSearch> RecentSearches { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CrmDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
