using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ORDER_DETAILSConfiguration : IEntityTypeConfiguration<ORDER_DETAILS>
{
    public void Configure(EntityTypeBuilder<ORDER_DETAILS> builder)
    {
        builder.ToTable("ORDER_DETAILS");
        builder.HasKey(x=> new { x.Id});
    }
}
