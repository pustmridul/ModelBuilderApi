using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CircularDiscountConfiguration : IEntityTypeConfiguration<CircularDiscount>
{
    public void Configure(EntityTypeBuilder<CircularDiscount> builder)
    {
        builder.ToTable("CIRCULAR_DISCOUNT");
        builder.HasNoKey();
    }
}
