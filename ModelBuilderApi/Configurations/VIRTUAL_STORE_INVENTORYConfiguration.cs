using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VIRTUAL_STORE_INVENTORYConfiguration : IEntityTypeConfiguration<VIRTUAL_STORE_INVENTORY>
{
    public void Configure(EntityTypeBuilder<VIRTUAL_STORE_INVENTORY> builder)
    {
        builder.ToTable("VIRTUAL_STORE_INVENTORY");
        builder.HasNoKey();
    }
}
