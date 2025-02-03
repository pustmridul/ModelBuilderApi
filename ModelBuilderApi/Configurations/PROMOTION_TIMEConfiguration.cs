using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PROMOTION_TIMEConfiguration : IEntityTypeConfiguration<PROMOTION_TIME>
{
    public void Configure(EntityTypeBuilder<PROMOTION_TIME> builder)
    {
        builder.ToTable("PROMOTION_TIME");
        builder.HasNoKey();
    }
}
