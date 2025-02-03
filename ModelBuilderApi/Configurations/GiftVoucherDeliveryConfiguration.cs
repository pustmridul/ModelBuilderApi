using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GiftVoucherDeliveryConfiguration : IEntityTypeConfiguration<GiftVoucherDelivery>
{
    public void Configure(EntityTypeBuilder<GiftVoucherDelivery> builder)
    {
        builder.ToTable("GiftVoucherDelivery");
        builder.HasNoKey();
    }
}
