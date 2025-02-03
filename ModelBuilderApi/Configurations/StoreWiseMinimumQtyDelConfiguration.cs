using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreWiseMinimumQtyDelConfiguration : IEntityTypeConfiguration<StoreWiseMinimumQtyDel>
{
    public void Configure(EntityTypeBuilder<StoreWiseMinimumQtyDel> builder)
    {
        builder.ToTable("StoreWiseMinimumQtyDel");
        builder.HasNoKey();
    }
}
