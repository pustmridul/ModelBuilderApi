using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_ALLOCATIONConfiguration : IEntityTypeConfiguration<STORE_ALLOCATION>
{
    public void Configure(EntityTypeBuilder<STORE_ALLOCATION> builder)
    {
        builder.ToTable("STORE_ALLOCATION");
        builder.HasKey(x => new { x.ALLOCATION_CODE, x.ALLOCATION_STORE_CODE, x.BARCODE, x.STORE_CODE, x.COMPANY_CODE });
    }
}
