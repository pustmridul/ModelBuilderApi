using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class OrderDeliveryScanConfiguration : IEntityTypeConfiguration<OrderDeliveryScan>
{
    public void Configure(EntityTypeBuilder<OrderDeliveryScan> builder)
    {
        builder.ToTable("OrderDeliveryScan");
        builder.HasKey(x=> new { x.Id });
    }
}
