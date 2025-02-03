using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PACKAGE_SALE_REGISTERConfiguration : IEntityTypeConfiguration<PACKAGE_SALE_REGISTER>
{
    public void Configure(EntityTypeBuilder<PACKAGE_SALE_REGISTER> builder)
    {
        builder.ToTable("PACKAGE_SALE_REGISTER");
        builder.HasNoKey();
    }
}
