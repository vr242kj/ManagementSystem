using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagementSystem.Infrastructure.Data.EntityTypeConfiguration
{
    public class RecentSearchEntityConfiguration : IEntityTypeConfiguration<RecentSearch>
    {
        public void Configure(EntityTypeBuilder<RecentSearch> builder)
        {
            builder.Property(p => p.Title).IsRequired();

            builder.HasOne(p => p.User)
            .WithMany(b => b.RecentSearches)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
