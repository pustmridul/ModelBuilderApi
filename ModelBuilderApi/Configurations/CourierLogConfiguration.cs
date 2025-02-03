using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CourierLogConfiguration : IEntityTypeConfiguration<CourierLog>
{
    public void Configure(EntityTypeBuilder<CourierLog> builder)
    {
        builder.ToTable("COURIER_LOG");
        builder.HasNoKey();
    }
}
