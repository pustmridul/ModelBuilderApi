using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCTConfiguration : IEntityTypeConfiguration<PRODUCT>
{
    public void Configure(EntityTypeBuilder<PRODUCT> builder)
    {
        builder.ToTable("PRODUCT");
        builder.HasKey(x=> new { x.COMPANY_CODE, x.BARCODE });
    }
}
