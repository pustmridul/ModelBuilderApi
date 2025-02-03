using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class Circular_Disc_BarcodeConfiguration : IEntityTypeConfiguration<Circular_Disc_Barcode>
{
    public void Configure(EntityTypeBuilder<Circular_Disc_Barcode> builder)
    {
        builder.ToTable("Circular_Disc_Barcode");
        builder.HasNoKey();
    }
}
