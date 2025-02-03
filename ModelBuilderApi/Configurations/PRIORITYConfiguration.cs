using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRIORITYConfiguration : IEntityTypeConfiguration<PRIORITY>
{
    public void Configure(EntityTypeBuilder<PRIORITY> builder)
    {
        builder.ToTable("PRIORITY");
        builder.HasKey(x=> new { x.PRIORITY_NAME });
    }
}
