using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GlobalSetupGLConfiguration : IEntityTypeConfiguration<GlobalSetupGL>
{
    public void Configure(EntityTypeBuilder<GlobalSetupGL> builder)
    {
        builder.ToTable("GlobalSetupGL");
        builder.HasKey(x=> new { x.ID });
    }
}
