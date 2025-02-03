using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CUSTOMER_CREDIT_LEDGERConfiguration : IEntityTypeConfiguration<CUSTOMER_CREDIT_LEDGER>
{
    public void Configure(EntityTypeBuilder<CUSTOMER_CREDIT_LEDGER> builder)
    {
        builder.ToTable("CUSTOMER_CREDIT_LEDGER");
        builder.HasKey(x => new { x.COMPANY_CODE, x.STORE_CODE, x.CUSTOMER_CODE });
    }
}
