using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class MANUFACTURERConfiguration : IEntityTypeConfiguration<MANUFACTURER>
{
    public void Configure(EntityTypeBuilder<MANUFACTURER> builder)
    {
        builder.ToTable("MANUFACTURER");
        builder.HasKey(x=> new { x.CODE });
    }
}
