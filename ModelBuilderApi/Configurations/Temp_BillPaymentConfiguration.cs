using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class Temp_BillPaymentConfiguration : IEntityTypeConfiguration<Temp_BillPayment>
{
    public void Configure(EntityTypeBuilder<Temp_BillPayment> builder)
    {
        builder.ToTable("Temp_BillPayment");
        builder.HasNoKey();
    }
}
