using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class P_SSUMMARYConfiguration : IEntityTypeConfiguration<P_SSUMMARY>
{
    public void Configure(EntityTypeBuilder<P_SSUMMARY> builder)
    {
        builder.ToTable("P_SSUMMARY");
        builder.HasNoKey();
    }
}
