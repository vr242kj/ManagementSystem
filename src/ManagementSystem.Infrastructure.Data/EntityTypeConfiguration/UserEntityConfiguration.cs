using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagementSystem.Infrastructure.Data.EntityTypeConfiguration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            //builder.Property(p => p.Email).IsRequired();

            builder.HasMany(t => t.Tasks)
                .WithOne()
                .HasForeignKey(task => task.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(t => t.Comments)
                .WithOne()
                .HasForeignKey(comment => comment.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(t => t.RecentSearches)
                .WithOne()
                .HasForeignKey(resentSearch => resentSearch.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
