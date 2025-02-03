using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class InvoiceDeliveryConfiguration : IEntityTypeConfiguration<InvoiceDelivery>
{
    public void Configure(EntityTypeBuilder<InvoiceDelivery> builder)
    {
        builder.ToTable("InvoiceDelivery");
        builder.HasNoKey();
    }
}
