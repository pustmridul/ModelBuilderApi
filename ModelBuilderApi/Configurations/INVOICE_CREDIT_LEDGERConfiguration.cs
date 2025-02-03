using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class INVOICE_CREDIT_LEDGERConfiguration : IEntityTypeConfiguration<INVOICE_CREDIT_LEDGER>
{
    public void Configure(EntityTypeBuilder<INVOICE_CREDIT_LEDGER> builder)
    {
        builder.ToTable("INVOICE_CREDIT_LEDGER");
        builder.HasKey(x=> new {  x.COMPANY_CODE, x.STORE_CODE, x.CUSTOMER_CODE, x.INVOICE_NO });
    }
}
