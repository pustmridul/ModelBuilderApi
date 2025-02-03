using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PHYSICAL_PRODUCT_STOCKConfiguration : IEntityTypeConfiguration<PHYSICAL_PRODUCT_STOCK>
{
    public void Configure(EntityTypeBuilder<PHYSICAL_PRODUCT_STOCK> builder)
    {
        builder.ToTable("PHYSICAL_PRODUCT_STOCK");
        builder.HasNoKey();
    }
}
