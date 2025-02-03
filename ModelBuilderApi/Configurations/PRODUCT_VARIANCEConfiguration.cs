using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_VARIANCEConfiguration : IEntityTypeConfiguration<PRODUCT_VARIANCE>
{
    public void Configure(EntityTypeBuilder<PRODUCT_VARIANCE> builder)
    {
        builder.ToTable("PRODUCT_VARIANCE");
        builder.HasKey(x=> new { x.VARIANCE_NAME, x.COMPANY_CODE });
    }
}
