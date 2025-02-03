using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PreGLConfiguration : IEntityTypeConfiguration<PreGL>
{
    public void Configure(EntityTypeBuilder<PreGL> builder)
    {
        builder.ToTable("PreGL");
        builder.HasNoKey();
    }
}
