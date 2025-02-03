using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PREGLStructureConfiguration : IEntityTypeConfiguration<PREGLStructure>
{
    public void Configure(EntityTypeBuilder<PREGLStructure> builder)
    {
        builder.ToTable("PREGLStructure");
        builder.HasNoKey();
    }
}
