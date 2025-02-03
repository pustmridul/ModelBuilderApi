using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_FILEConfiguration : IEntityTypeConfiguration<PRODUCT_FILE>
{
    public void Configure(EntityTypeBuilder<PRODUCT_FILE> builder)
    {
        builder.ToTable("PRODUCT_FILE");
        builder.HasKey(x=> new { x.COMPANY_CODE, x.BARCODE });
    }
}
