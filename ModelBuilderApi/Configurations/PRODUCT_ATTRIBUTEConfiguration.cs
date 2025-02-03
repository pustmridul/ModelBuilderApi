using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_ATTRIBUTEConfiguration : IEntityTypeConfiguration<PRODUCT_ATTRIBUTE>
{
    public void Configure(EntityTypeBuilder<PRODUCT_ATTRIBUTE> builder)
    {
        builder.ToTable("PRODUCT_ATTRIBUTE");
        builder.HasNoKey();
    }
}
