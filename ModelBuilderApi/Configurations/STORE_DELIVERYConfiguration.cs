using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_DELIVERYConfiguration : IEntityTypeConfiguration<STORE_DELIVERY>
{
    public void Configure(EntityTypeBuilder<STORE_DELIVERY> builder)
    {
        builder.ToTable("STORE_DELIVERY");
        builder.HasNoKey();
    }
}
