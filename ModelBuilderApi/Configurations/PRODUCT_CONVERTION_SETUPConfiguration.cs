using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_CONVERTION_SETUPConfiguration : IEntityTypeConfiguration<PRODUCT_CONVERTION_SETUP>
{
    public void Configure(EntityTypeBuilder<PRODUCT_CONVERTION_SETUP> builder)
    {
        builder.ToTable("PRODUCT_CONVERTION_SETUP");
        builder.HasKey(x=> new { x.BARCODE, x.CONVERABLE_BARCODE, x.COMPANY_CODE });
    }
}
