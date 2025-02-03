using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PurchaseOrderGLLogConfiguration : IEntityTypeConfiguration<PurchaseOrderGLLog>
{
    public void Configure(EntityTypeBuilder<PurchaseOrderGLLog> builder)
    {
        builder.ToTable("PurchaseOrderGLLog");
        builder.HasNoKey();
    }
}
