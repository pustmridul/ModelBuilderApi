using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PURCHASE_ORDER_DETAILSConfiguration : IEntityTypeConfiguration<PURCHASE_ORDER_DETAILS>
{
    public void Configure(EntityTypeBuilder<PURCHASE_ORDER_DETAILS> builder)
    {
        builder.ToTable("PURCHASE_ORDER_DETAILS");
        builder.HasKey(x => new { x.COMPANY_CODE, x.STORE_CODE, x.ORDER_NO, x.BARCODE });
    }
}
