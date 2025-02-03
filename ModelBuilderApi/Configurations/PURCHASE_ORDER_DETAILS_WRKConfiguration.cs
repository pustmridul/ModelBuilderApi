using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PURCHASE_ORDER_DETAILS_WRKConfiguration : IEntityTypeConfiguration<PURCHASE_ORDER_DETAILS_WRK>
{
    public void Configure(EntityTypeBuilder<PURCHASE_ORDER_DETAILS_WRK> builder)
    {
        builder.ToTable("PURCHASE_ORDER_DETAILS_WRK");
        builder.HasNoKey();
    }
}
