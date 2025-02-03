using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomerUpgradationDegradationConfiguration : IEntityTypeConfiguration<CustomerUpgradationDegradation>
{
    public void Configure(EntityTypeBuilder<CustomerUpgradationDegradation> builder)
    {
        builder.ToTable("CustomerUpgradationDegradation");
        builder.HasNoKey();
    }
}
