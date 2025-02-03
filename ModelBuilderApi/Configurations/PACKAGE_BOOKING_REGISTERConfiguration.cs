using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PACKAGE_BOOKING_REGISTERConfiguration : IEntityTypeConfiguration<PACKAGE_BOOKING_REGISTER>
{
    public void Configure(EntityTypeBuilder<PACKAGE_BOOKING_REGISTER> builder)
    {
        builder.ToTable("PACKAGE_BOOKING_REGISTER");
        builder.HasNoKey();
    }
}
