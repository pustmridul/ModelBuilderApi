using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class INVALID_PRODUCT_SALE_REGISTERConfiguration : IEntityTypeConfiguration<INVALID_PRODUCT_SALE_REGISTER>
{
    public void Configure(EntityTypeBuilder<INVALID_PRODUCT_SALE_REGISTER> builder)
    {
        builder.ToTable("INVALID_PRODUCT_SALE_REGISTER");
        builder.HasNoKey();
    }
}
