using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomerCardConfiguration : IEntityTypeConfiguration<CustomerCard>
{
    public void Configure(EntityTypeBuilder<CustomerCard> builder)
    {
        builder.ToTable("CUSTOMER_CARD");
        builder.HasNoKey();
    }
}
