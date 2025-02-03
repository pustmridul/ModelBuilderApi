using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PROMOTION_HISTORYConfiguration : IEntityTypeConfiguration<PROMOTION_HISTORY>
{
    public void Configure(EntityTypeBuilder<PROMOTION_HISTORY> builder)
    {
        builder.ToTable("PROMOTION_HISTORY");
        builder.HasNoKey();
    }
}
