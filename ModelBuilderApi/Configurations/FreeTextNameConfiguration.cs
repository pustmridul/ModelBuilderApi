using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class FreeTextNameConfiguration : IEntityTypeConfiguration<FreeTextName>
{
    public void Configure(EntityTypeBuilder<FreeTextName> builder)
    {
        builder.ToTable("FreeTextName");
        builder.HasNoKey();
    }
}
