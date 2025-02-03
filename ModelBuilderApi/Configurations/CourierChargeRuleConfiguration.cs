using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CourierChargeRuleConfiguration : IEntityTypeConfiguration<CourierChargeRule>
{
    public void Configure(EntityTypeBuilder<CourierChargeRule> builder)
    {
        builder.ToTable("CourierChargeRule");
        builder.HasKey(x => new { x.CourierId });
    }
}
