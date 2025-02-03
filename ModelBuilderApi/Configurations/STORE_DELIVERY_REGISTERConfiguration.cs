using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_DELIVERY_REGISTERConfiguration : IEntityTypeConfiguration<STORE_DELIVERY_REGISTER>
{
    public void Configure(EntityTypeBuilder<STORE_DELIVERY_REGISTER> builder)
    {
        builder.ToTable("STORE_DELIVERY_REGISTER");
        builder.HasNoKey();
    }
}
