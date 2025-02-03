using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class Temp_GLHOConfiguration : IEntityTypeConfiguration<Temp_GLHO>
{
    public void Configure(EntityTypeBuilder<Temp_GLHO> builder)
    {
        builder.ToTable("Temp_GLHO");
        builder.HasKey(x => new { x.CMPIDX});
    }
}
