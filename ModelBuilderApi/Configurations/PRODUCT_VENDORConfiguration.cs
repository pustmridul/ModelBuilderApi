using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_VENDORConfiguration : IEntityTypeConfiguration<PRODUCT_VENDOR>
{
    public void Configure(EntityTypeBuilder<PRODUCT_VENDOR> builder)
    {
        builder.ToTable("PRODUCT_VENDOR");
        builder.HasKey(x=> new { x.BARCODE, x.VENDOR_CODE, x.USER_BARCODE });
    }
}
