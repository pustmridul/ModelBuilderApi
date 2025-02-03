using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class GLTemConfiguration : IEntityTypeConfiguration<GLTem>
{
    public void Configure(EntityTypeBuilder<GLTem> builder)
    {
        builder.ToTable("GLTem");
        builder.HasNoKey();
    }
}
