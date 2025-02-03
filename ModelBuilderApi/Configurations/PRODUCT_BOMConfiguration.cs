using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_BOMConfiguration : IEntityTypeConfiguration<PRODUCT_BOM>
{
    public void Configure(EntityTypeBuilder<PRODUCT_BOM> builder)
    {
        builder.ToTable("PRODUCT_BOM");
        builder.HasKey(x=> new { x.BARCODE, x.ING_BARCODE, x.COMPANY_CODE });
    }
}
