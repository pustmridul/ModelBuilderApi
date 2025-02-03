using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreNotificationConfiguration : IEntityTypeConfiguration<StoreNotification>
{
    public void Configure(EntityTypeBuilder<StoreNotification> builder)
    {
        builder.ToTable("StoreNotification");
        builder.HasNoKey();
    }
}
