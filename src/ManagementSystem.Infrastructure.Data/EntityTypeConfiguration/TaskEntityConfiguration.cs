using ManagementSystem.Core.Entities;
using Microsoft.AspNetCore.Identity;
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

            builder.HasMany(t => t.Comments)
            .WithOne(c => c.Task)
            .HasForeignKey(c => c.TaskId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
