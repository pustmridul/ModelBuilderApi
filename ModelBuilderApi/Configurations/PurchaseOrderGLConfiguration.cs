using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PurchaseOrderGLConfiguration : IEntityTypeConfiguration<PurchaseOrderGL>
{
    public void Configure(EntityTypeBuilder<PurchaseOrderGL> builder)
    {
        builder.ToTable("PurchaseOrderGL");
        builder.HasNoKey();
    }
}
