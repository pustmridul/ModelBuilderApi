using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SALE_ORDERConfiguration : IEntityTypeConfiguration<SALE_ORDER>
{
    public void Configure(EntityTypeBuilder<SALE_ORDER> builder)
    {
        builder.ToTable("SALE_ORDER");
        builder.HasNoKey();
    }
}
