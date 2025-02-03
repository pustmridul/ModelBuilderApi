using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GIFT_VOUCHER_GENERATION_LOGConfiguration : IEntityTypeConfiguration<GIFT_VOUCHER_GENERATION_LOG>
{
    public void Configure(EntityTypeBuilder<GIFT_VOUCHER_GENERATION_LOG> builder)
    {
        builder.ToTable("GIFT_VOUCHER_GENERATION_LOG");
        builder.HasNoKey();
    }
}
