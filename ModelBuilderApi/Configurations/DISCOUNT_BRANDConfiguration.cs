using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DISCOUNT_BRANDConfiguration : IEntityTypeConfiguration<DISCOUNT_BRAND>
{
    public void Configure(EntityTypeBuilder<DISCOUNT_BRAND> builder)
    {
        builder.ToTable("DISCOUNT_BRAND");
        builder.HasNoKey();
    }
}
