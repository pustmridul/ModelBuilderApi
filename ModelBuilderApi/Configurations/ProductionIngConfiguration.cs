using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ProductionIngConfiguration : IEntityTypeConfiguration<ProductionIng>
{
    public void Configure(EntityTypeBuilder<ProductionIng> builder)
    {
        builder.ToTable("ProductionIng");
        builder.HasNoKey();
    }
}
