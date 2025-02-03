using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_ALLOCATION_WRKConfiguration : IEntityTypeConfiguration<STORE_ALLOCATION_WRK>
{
    public void Configure(EntityTypeBuilder<STORE_ALLOCATION_WRK> builder)
    {
        builder.ToTable("STORE_ALLOCATION_WRK");
        builder.HasNoKey();
    }
}
