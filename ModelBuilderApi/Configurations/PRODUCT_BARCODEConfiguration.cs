using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_BARCODEConfiguration : IEntityTypeConfiguration<PRODUCT_BARCODE>
{
    public void Configure(EntityTypeBuilder<PRODUCT_BARCODE> builder)
    {
        builder.ToTable("PRODUCT_BARCODE");
        builder.HasKey(x=> new { x.BARCODE, x.USER_BARCODE });
    }
}
