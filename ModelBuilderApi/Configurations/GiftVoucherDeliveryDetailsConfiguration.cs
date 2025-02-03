using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GiftVoucherDeliveryDetailsConfiguration : IEntityTypeConfiguration<GiftVoucherDeliveryDetails>
{
    public void Configure(EntityTypeBuilder<GiftVoucherDeliveryDetails> builder)
    {
        builder.ToTable("GiftVoucherDeliveryDetails");
        builder.HasNoKey();
    }
}
