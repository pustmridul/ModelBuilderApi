using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class UserMenuDistributionConfiguration : IEntityTypeConfiguration<UserMenuDistribution>
{
    public void Configure(EntityTypeBuilder<UserMenuDistribution> builder)
    {
        builder.ToTable("UserMenuDistribution");
        builder.HasNoKey();
    }
}
