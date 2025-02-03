using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomerBarcodeConfiguration : IEntityTypeConfiguration<CustomerBarcode>
{
    public void Configure(EntityTypeBuilder<CustomerBarcode> builder)
    {
        builder.ToTable("CUSTOMER_BARCODE");
        builder.HasNoKey();
    }
}
