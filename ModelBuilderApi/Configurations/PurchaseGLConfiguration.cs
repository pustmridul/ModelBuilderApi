using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PurchaseGLConfiguration : IEntityTypeConfiguration<PurchaseGL>
{
    public void Configure(EntityTypeBuilder<PurchaseGL> builder)
    {
        builder.ToTable("PurchaseGL");
        builder.HasNoKey();
    }
}
