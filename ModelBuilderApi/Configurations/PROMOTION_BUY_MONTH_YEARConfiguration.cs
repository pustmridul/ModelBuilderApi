using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PROMOTION_BUY_MONTH_YEARConfiguration : IEntityTypeConfiguration<PROMOTION_BUY_MONTH_YEAR>
{
    public void Configure(EntityTypeBuilder<PROMOTION_BUY_MONTH_YEAR> builder)
    {
        builder.ToTable("PROMOTION_BUY_MONTH_YEAR");
        builder.HasNoKey();
    }
}
