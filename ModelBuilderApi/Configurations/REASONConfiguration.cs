using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class REASONConfiguration : IEntityTypeConfiguration<REASON>
{
    public void Configure(EntityTypeBuilder<REASON> builder)
    {
        builder.ToTable("REASON");
        builder.HasKey(x => new { x.CODE });
    }
}
