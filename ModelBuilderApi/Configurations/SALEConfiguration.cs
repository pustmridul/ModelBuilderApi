using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SALEConfiguration : IEntityTypeConfiguration<SALE>
{
    public void Configure(EntityTypeBuilder<SALE> builder)
    {
        builder.ToTable("SALE");
        builder.HasKey(x => new { x.INVOICE_NO, x.INVOICE_DT, x.BARCODE, x.USER_BARCODE, x.SAL_BARCODE, x.MRP, x.SQTY, x.RQTY, x.STORE_CODE });
    }
}
