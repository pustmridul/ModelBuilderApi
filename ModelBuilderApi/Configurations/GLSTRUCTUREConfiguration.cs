using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GLSTRUCTUREConfiguration : IEntityTypeConfiguration<GLSTRUCTURE>
{
    public void Configure(EntityTypeBuilder<GLSTRUCTURE> builder)
    {
        builder.ToTable("GLSTRUCTURE");
        builder.HasNoKey();
    }
}
