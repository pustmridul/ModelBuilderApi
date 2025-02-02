using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class AgeRangeConfiguration : IEntityTypeConfiguration<AgeRange>
{
    public void Configure(EntityTypeBuilder<AgeRange> builder)
    {
        builder.ToTable("AgeRange");
        builder.HasKey(x => new { x.RANGE });
    }
}
