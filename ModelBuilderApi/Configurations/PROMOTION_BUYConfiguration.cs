using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PROMOTION_BUYConfiguration : IEntityTypeConfiguration<PROMOTION_BUY>
{
    public void Configure(EntityTypeBuilder<PROMOTION_BUY> builder)
    {
        builder.ToTable("PROMOTION_BUY");
        builder.HasNoKey();
    }
}
