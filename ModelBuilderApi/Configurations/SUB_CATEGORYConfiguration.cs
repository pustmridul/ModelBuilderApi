using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SUB_CATEGORYConfiguration : IEntityTypeConfiguration<SUB_CATEGORY>
{
    public void Configure(EntityTypeBuilder<SUB_CATEGORY> builder)
    {
        builder.ToTable("SUB_CATEGORY");
        builder.HasNoKey();
    }
}
