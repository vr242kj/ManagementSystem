using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagementSystem.Infrastructure.Data.EntityTypeConfiguration
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Surename).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Status).IsRequired();
        }
    }
}
