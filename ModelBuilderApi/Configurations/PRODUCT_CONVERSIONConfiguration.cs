using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_CONVERSIONConfiguration : IEntityTypeConfiguration<PRODUCT_CONVERSION>
{
    public void Configure(EntityTypeBuilder<PRODUCT_CONVERSION> builder)
    {
        builder.ToTable("PRODUCT_CONVERSION");
        builder.HasNoKey();
    }
}
