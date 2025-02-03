using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomerPriceSetupConfiguration : IEntityTypeConfiguration<CustomerPriceSetup>
{
    public void Configure(EntityTypeBuilder<CustomerPriceSetup> builder)
    {
        builder.ToTable("CUSTOMER_PRICE_SETUP");
        builder.HasKey(x => new { x.COMPANY_CODE, x.CUSTOMER_CODE, x.BARCODE });
    }
}
