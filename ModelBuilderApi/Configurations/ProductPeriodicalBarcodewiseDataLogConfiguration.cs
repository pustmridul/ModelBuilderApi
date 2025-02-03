using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ProductPeriodicalBarcodewiseDataLogConfiguration : IEntityTypeConfiguration<ProductPeriodicalBarcodewiseDataLog>
{
    public void Configure(EntityTypeBuilder<ProductPeriodicalBarcodewiseDataLog> builder)
    {
        builder.ToTable("ProductPeriodicalBarcodewiseDataLog");
        builder.HasNoKey();
    }
}
