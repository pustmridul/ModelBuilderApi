using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_VENDOR_USER_BARCODEConfiguration : IEntityTypeConfiguration<PRODUCT_VENDOR_USER_BARCODE>
{
    public void Configure(EntityTypeBuilder<PRODUCT_VENDOR_USER_BARCODE> builder)
    {
        builder.ToTable("PRODUCT_VENDOR_USER_BARCODE");
        builder.HasNoKey();
    }
}
