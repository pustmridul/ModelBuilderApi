using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ROLEConfiguration : IEntityTypeConfiguration<ROLE>
{
    public void Configure(EntityTypeBuilder<ROLE> builder)
    {
        builder.ToTable("ROLE");
        builder.HasNoKey();
    }
}
