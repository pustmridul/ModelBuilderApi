using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VENDOR_REGISTRATION_INFOConfiguration : IEntityTypeConfiguration<VENDOR_REGISTRATION_INFO>
{
    public void Configure(EntityTypeBuilder<VENDOR_REGISTRATION_INFO> builder)
    {
        builder.ToTable("VENDOR_REGISTRATION_INFO");
        builder.HasNoKey();
    }
}
