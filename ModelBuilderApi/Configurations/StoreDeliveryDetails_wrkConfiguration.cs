using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreDeliveryDetails_wrkConfiguration : IEntityTypeConfiguration<StoreDeliveryDetails_wrk>
{
    public void Configure(EntityTypeBuilder<StoreDeliveryDetails_wrk> builder)
    {
        builder.ToTable("StoreDeliveryDetails_wrk");
        builder.HasNoKey();
    }
}
