using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CHALLAN_WISE_DISTRIBUTION_PLANConfiguration : IEntityTypeConfiguration<CHALLAN_WISE_DISTRIBUTION_PLAN>
{
    public void Configure(EntityTypeBuilder<CHALLAN_WISE_DISTRIBUTION_PLAN> builder)
    {
        builder.ToTable("CHALLAN_WISE_DISTRIBUTION_PLAN");
        builder.HasNoKey();
    }
}
