using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GIFT_VOUCHER_GENERATIONConfiguration : IEntityTypeConfiguration<GIFT_VOUCHER_GENERATION>
{
    public void Configure(EntityTypeBuilder<GIFT_VOUCHER_GENERATION> builder)
    {
        builder.ToTable("GIFT_VOUCHER_GENERATION");
        builder.HasNoKey();
    }
}
