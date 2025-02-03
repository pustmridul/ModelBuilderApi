using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PURCHASE_RCV_DETAILSConfiguration : IEntityTypeConfiguration<PURCHASE_RCV_DETAILS>
{
    public void Configure(EntityTypeBuilder<PURCHASE_RCV_DETAILS> builder)
    {
        builder.ToTable("PURCHASE_RCV_DETAILS");
        builder.HasKey(x => new { x.MEMO_NO, x.PURCHASE_DATE, x.STORE_CODE, x.SAL_BARCODE, x.SAL_PRICE });
    }
}
