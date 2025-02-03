using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_STOCKConfiguration : IEntityTypeConfiguration<PRODUCT_STOCK>
{
    public void Configure(EntityTypeBuilder<PRODUCT_STOCK> builder)
    {
        builder.ToTable("PRODUCT_STOCK");
        builder.HasKey(x=> new { x.STORE_CODE, x.SAL_BARCODE, x.SAL_PRICE });
    }
}
