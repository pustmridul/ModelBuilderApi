using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PROMOTION_GETConfiguration : IEntityTypeConfiguration<PROMOTION_GET>
{
    public void Configure(EntityTypeBuilder<PROMOTION_GET> builder)
    {
        builder.ToTable("PROMOTION_GET");
        builder.HasNoKey();
    }
}
