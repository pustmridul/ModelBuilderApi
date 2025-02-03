using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VENDOR_CONTACTConfiguration : IEntityTypeConfiguration<VENDOR_CONTACT>
{
    public void Configure(EntityTypeBuilder<VENDOR_CONTACT> builder)
    {
        builder.ToTable("VENDOR_CONTACT");
        builder.HasNoKey();
    }
}
