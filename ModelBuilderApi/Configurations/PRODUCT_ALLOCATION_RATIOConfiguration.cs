using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_ALLOCATION_RATIOConfiguration : IEntityTypeConfiguration<PRODUCT_ALLOCATION_RATIO>
{
    public void Configure(EntityTypeBuilder<PRODUCT_ALLOCATION_RATIO> builder)
    {
        builder.ToTable("PRODUCT_ALLOCATION_RATIO");
        builder.HasKey(x=> new { x.ALLOCATION_CODE, x.PARENT_PRODUCT });
    }
}
