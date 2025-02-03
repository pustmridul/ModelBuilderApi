using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class P_SALE_PAYMENTConfiguration : IEntityTypeConfiguration<P_SALE_PAYMENT>
{
    public void Configure(EntityTypeBuilder<P_SALE_PAYMENT> builder)
    {
        builder.ToTable("P_SALE_PAYMENT");
        builder.HasNoKey();
    }
}
