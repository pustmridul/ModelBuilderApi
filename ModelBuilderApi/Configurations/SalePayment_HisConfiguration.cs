using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SalePayment_HisConfiguration : IEntityTypeConfiguration<SalePayment_His>
{
    public void Configure(EntityTypeBuilder<SalePayment_His> builder)
    {
        builder.ToTable("SalePayment_His");
        builder.HasNoKey();
    }
}
