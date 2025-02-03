using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VENDOR_ADDITIONAL_INFOConfiguration : IEntityTypeConfiguration<VENDOR_ADDITIONAL_INFO>
{
    public void Configure(EntityTypeBuilder<VENDOR_ADDITIONAL_INFO> builder)
    {
        builder.ToTable("VENDOR_ADDITIONAL_INFO");
        builder.HasNoKey();
    }
}
