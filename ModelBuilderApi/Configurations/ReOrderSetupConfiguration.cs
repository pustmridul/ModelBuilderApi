using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ReOrderSetupConfiguration : IEntityTypeConfiguration<ReOrderSetup>
{
    public void Configure(EntityTypeBuilder<ReOrderSetup> builder)
    {
        builder.ToTable("ReOrderSetup");
        builder.HasKey(x => new { x.Barcode, x.StoreCode });
    }
}
