using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_PRODUCT_BARCODEConfiguration : IEntityTypeConfiguration<STORE_PRODUCT_BARCODE>
{
    public void Configure(EntityTypeBuilder<STORE_PRODUCT_BARCODE> builder)
    {
        builder.ToTable("STORE_PRODUCT_BARCODE");
        builder.HasKey(x => new { x.COMPANY_CODE, x.STORE_CODE, x.PRODUCT_CODE, x.USER_BARCODE, x.STORE_BARCODE });
    }
}
