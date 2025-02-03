using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_VARIANCE_SEQUENCEConfiguration : IEntityTypeConfiguration<PRODUCT_VARIANCE_SEQUENCE>
{
    public void Configure(EntityTypeBuilder<PRODUCT_VARIANCE_SEQUENCE> builder)
    {
        builder.ToTable("PRODUCT_VARIANCE_SEQUENCE");
        builder.HasNoKey();
    }
}
