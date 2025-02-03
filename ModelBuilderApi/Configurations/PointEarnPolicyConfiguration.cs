using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PointEarnPolicyConfiguration : IEntityTypeConfiguration<PointEarnPolicy>
{
    public void Configure(EntityTypeBuilder<PointEarnPolicy> builder)
    {
        builder.ToTable("PointEarnPolicy");
        builder.HasNoKey();
    }
}
