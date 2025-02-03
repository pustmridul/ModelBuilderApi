using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreDelivery_WrkConfiguration : IEntityTypeConfiguration<StoreDelivery_Wrk>
{
    public void Configure(EntityTypeBuilder<StoreDelivery_Wrk> builder)
    {
        builder.ToTable("StoreDelivery_Wrk");
        builder.HasNoKey();
    }
}
