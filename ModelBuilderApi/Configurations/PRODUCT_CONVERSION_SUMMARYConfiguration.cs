using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_CONVERSION_SUMMARYConfiguration : IEntityTypeConfiguration<PRODUCT_CONVERSION_SUMMARY>
{
    public void Configure(EntityTypeBuilder<PRODUCT_CONVERSION_SUMMARY> builder)
    {
        builder.ToTable("PRODUCT_CONVERSION_SUMMARY");
        builder.HasNoKey();
    }
}
