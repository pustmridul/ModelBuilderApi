using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CourierServiceConfiguration : IEntityTypeConfiguration<CourierService>
{
    public void Configure(EntityTypeBuilder<CourierService> builder)
    {
        builder.ToTable("CourierService");
        builder.HasNoKey();
    }
}
