using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_OPTIONSConfiguration : IEntityTypeConfiguration<PRODUCT_OPTIONS>
{
    public void Configure(EntityTypeBuilder<PRODUCT_OPTIONS> builder)
    {
        builder.ToTable("PRODUCT_OPTIONS");
        builder.HasNoKey();
    }
}
