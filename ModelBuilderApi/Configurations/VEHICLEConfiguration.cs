using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VEHICLEConfiguration : IEntityTypeConfiguration<VEHICLE>
{
    public void Configure(EntityTypeBuilder<VEHICLE> builder)
    {
        builder.ToTable("VEHICLE");
        builder.HasKey(x => new { x.CODE, x.COMPANY_CODE });
    }
}
