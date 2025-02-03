using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ProductConversionWrkConfiguration : IEntityTypeConfiguration<ProductConversionWrk>
{
    public void Configure(EntityTypeBuilder<ProductConversionWrk> builder)
    {
        builder.ToTable("USERS");
        builder.HasNoKey();
    }
}
