using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PROMOTION_STOREConfiguration : IEntityTypeConfiguration<PROMOTION_STORE>
{
    public void Configure(EntityTypeBuilder<PROMOTION_STORE> builder)
    {
        builder.ToTable("PROMOTION_STORE");
        builder.HasNoKey();
    }
}
