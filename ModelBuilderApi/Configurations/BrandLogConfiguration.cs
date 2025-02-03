using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class BrandLogConfiguration : IEntityTypeConfiguration<BrandLog>
{
    public void Configure(EntityTypeBuilder<BrandLog> builder)
    {
        builder.ToTable("BRAND_Log");
        builder.HasNoKey();
    }
}
