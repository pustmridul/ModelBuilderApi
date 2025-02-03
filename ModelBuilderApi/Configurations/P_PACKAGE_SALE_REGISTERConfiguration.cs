using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class P_PACKAGE_SALE_REGISTERConfiguration : IEntityTypeConfiguration<P_PACKAGE_SALE_REGISTER>
{
    public void Configure(EntityTypeBuilder<P_PACKAGE_SALE_REGISTER> builder)
    {
        builder.ToTable("P_PACKAGE_SALE_REGISTER");
        builder.HasNoKey();
    }
}
