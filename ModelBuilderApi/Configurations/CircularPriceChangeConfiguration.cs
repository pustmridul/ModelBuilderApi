using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CircularPriceChangeConfiguration : IEntityTypeConfiguration<CircularPriceChange>
{
    public void Configure(EntityTypeBuilder<CircularPriceChange> builder)
    {
        builder.ToTable("CIRCULAR_PRICE_CHANGE");
        builder.HasNoKey();
    }
}
