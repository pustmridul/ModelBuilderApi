using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GIFT_ITEM_STOCKConfiguration : IEntityTypeConfiguration<GIFT_ITEM_STOCK>
{
    public void Configure(EntityTypeBuilder<GIFT_ITEM_STOCK> builder)
    {
        builder.ToTable("GIFT_ITEM_STOCK");
        builder.HasNoKey();
    }
}
