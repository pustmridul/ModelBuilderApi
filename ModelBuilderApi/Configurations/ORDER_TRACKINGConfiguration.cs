using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ORDER_TRACKINGConfiguration : IEntityTypeConfiguration<ORDER_TRACKING>
{
    public void Configure(EntityTypeBuilder<ORDER_TRACKING> builder)
    {
        builder.ToTable("ORDER_TRACKING");
        builder.HasKey(x=> new { x.ID });
    }
}
