using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DESIRED_STOCK_SETUPConfiguration : IEntityTypeConfiguration<DESIRED_STOCK_SETUP>
{
    public void Configure(EntityTypeBuilder<DESIRED_STOCK_SETUP> builder)
    {
        builder.ToTable("DESIRED_STOCK_SETUP");
        builder.HasKey(x=> new { x.STORE_CODE, x.BARCODE });
    }
}
