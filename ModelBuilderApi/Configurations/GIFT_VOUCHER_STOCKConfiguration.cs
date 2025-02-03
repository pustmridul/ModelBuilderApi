using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GIFT_VOUCHER_STOCKConfiguration : IEntityTypeConfiguration<GIFT_VOUCHER_STOCK>
{
    public void Configure(EntityTypeBuilder<GIFT_VOUCHER_STOCK> builder)
    {
        builder.ToTable("GIFT_VOUCHER_STOCK");
        builder.HasNoKey();
    }
}
