using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class REJ_STORE_DELIVERY_DETAILSConfiguration : IEntityTypeConfiguration<REJ_STORE_DELIVERY_DETAILS>
{
    public void Configure(EntityTypeBuilder<REJ_STORE_DELIVERY_DETAILS> builder)
    {
        builder.ToTable("REJ_STORE_DELIVERY_DETAILS");
        builder.HasNoKey();
    }
}
