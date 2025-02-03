using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_BRANDConfiguration : IEntityTypeConfiguration<STORE_BRAND>
{
    public void Configure(EntityTypeBuilder<STORE_BRAND> builder)
    {
        builder.ToTable("STORE_BRAND");
        builder.HasKey(x => new { x.COMPANY_CODE, x.STORE_CODE, x.BRAND_CODE });
    }
}
