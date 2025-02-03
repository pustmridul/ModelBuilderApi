using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CourierLocationConfiguration : IEntityTypeConfiguration<CourierLocation>
{
    public void Configure(EntityTypeBuilder<CourierLocation> builder)
    {
        builder.ToTable("CourierLocation");
        builder.HasKey(x => new { x.LOCATION_CODE });
    }
}
