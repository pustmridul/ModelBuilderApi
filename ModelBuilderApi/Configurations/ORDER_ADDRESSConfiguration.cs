using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ORDER_ADDRESSConfiguration : IEntityTypeConfiguration<ORDER_ADDRESS>
{
    public void Configure(EntityTypeBuilder<ORDER_ADDRESS> builder)
    {
        builder.ToTable("ORDER_ADDRESS");
        builder.HasKey(x=> new { x.Id });
    }
}
