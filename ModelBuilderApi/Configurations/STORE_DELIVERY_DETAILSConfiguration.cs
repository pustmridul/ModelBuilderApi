using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_DELIVERY_DETAILSConfiguration : IEntityTypeConfiguration<STORE_DELIVERY_DETAILS>
{
    public void Configure(EntityTypeBuilder<STORE_DELIVERY_DETAILS> builder)
    {
        builder.ToTable("STORE_DELIVERY_DETAILS");
        builder.HasNoKey();
    }
}
