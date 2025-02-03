using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ProductPeriodicalBarcodewiseDataConfiguration : IEntityTypeConfiguration<ProductPeriodicalBarcodewiseData>
{
    public void Configure(EntityTypeBuilder<ProductPeriodicalBarcodewiseData> builder)
    {
        builder.ToTable("ProductPeriodicalBarcodewiseData");
        builder.HasNoKey();
    }
}
