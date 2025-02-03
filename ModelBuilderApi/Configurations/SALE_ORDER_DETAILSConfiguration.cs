using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SALE_ORDER_DETAILSConfiguration : IEntityTypeConfiguration<SALE_ORDER_DETAILS>
{
    public void Configure(EntityTypeBuilder<SALE_ORDER_DETAILS> builder)
    {
        builder.ToTable("SALE_ORDER_DETAILS");
        builder.HasNoKey();
    }
}
