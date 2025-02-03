using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DISCOUNT_NONBRANDConfiguration : IEntityTypeConfiguration<DISCOUNT_NONBRAND>
{
    public void Configure(EntityTypeBuilder<DISCOUNT_NONBRAND> builder)
    {
        builder.ToTable("DISCOUNT_NONBRAND");
        builder.HasNoKey();
    }
}
