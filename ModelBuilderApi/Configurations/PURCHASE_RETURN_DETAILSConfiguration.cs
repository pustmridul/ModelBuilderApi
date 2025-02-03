using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PURCHASE_RETURN_DETAILSConfiguration : IEntityTypeConfiguration<PURCHASE_RETURN_DETAILS>
{
    public void Configure(EntityTypeBuilder<PURCHASE_RETURN_DETAILS> builder)
    {
        builder.ToTable("PURCHASE_RETURN_DETAILS");
        builder.HasNoKey();
    }
}
