using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ORDERConfiguration : IEntityTypeConfiguration<ORDER>
{
    public void Configure(EntityTypeBuilder<ORDER> builder)
    {
        builder.ToTable("ORDER");
        builder.HasKey(x=> new { x.Id});
    }
}
