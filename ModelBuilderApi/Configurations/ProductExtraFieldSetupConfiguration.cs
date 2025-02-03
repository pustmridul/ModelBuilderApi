using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ProductExtraFieldSetupConfiguration : IEntityTypeConfiguration<ProductExtraFieldSetup>
{
    public void Configure(EntityTypeBuilder<ProductExtraFieldSetup> builder)
    {
        builder.ToTable("ProductExtraFieldSetup");
        builder.HasNoKey();
    }
}
