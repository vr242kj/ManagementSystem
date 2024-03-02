using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = ManagementSystem.Core.Entities.Task;


namespace ManagementSystem.Infrastructure.Data.EntityTypeConfiguration
{
    public class TaskEntityConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.ClassOfPriority).IsRequired();
        }
    }
}
