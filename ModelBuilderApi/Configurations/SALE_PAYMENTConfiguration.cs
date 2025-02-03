using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SALE_PAYMENTConfiguration : IEntityTypeConfiguration<SALE_PAYMENT>
{
    public void Configure(EntityTypeBuilder<SALE_PAYMENT> builder)
    {
        builder.ToTable("SALE_PAYMENT");
        builder.HasNoKey();
    }
}
