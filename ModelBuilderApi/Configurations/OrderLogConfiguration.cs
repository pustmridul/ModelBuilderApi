using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class OrderLogConfiguration : IEntityTypeConfiguration<OrderLog>
{
    public void Configure(EntityTypeBuilder<OrderLog> builder)
    {
        builder.ToTable("OrderLog");
        builder.HasKey(x=> new { x.Id });
    }
}
