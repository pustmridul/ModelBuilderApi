using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_CARTONConfiguration : IEntityTypeConfiguration<PRODUCT_CARTON>
{
    public void Configure(EntityTypeBuilder<PRODUCT_CARTON> builder)
    {
        builder.ToTable("PRODUCT_CARTON");
        builder.HasKey(x=> new { x.BARCODE, x.CARTON_BARCODE, x.CARTON_USER_BARCODE, x.COMPANY_CODE });
    }
}
