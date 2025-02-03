using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ORDER_DETAILS_WRKConfiguration : IEntityTypeConfiguration<ORDER_DETAILS_WRK>
{
    public void Configure(EntityTypeBuilder<ORDER_DETAILS_WRK> builder)
    {
        builder.ToTable("ORDER_DETAILS_WRK");
        builder.HasKey(x=> new { x.Id });
    }
}
