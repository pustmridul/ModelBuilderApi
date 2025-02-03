using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SalePayment_wrkConfiguration : IEntityTypeConfiguration<SalePayment_wrk>
{
    public void Configure(EntityTypeBuilder<SalePayment_wrk> builder)
    {
        builder.ToTable("SalePayment_wrk");
        builder.HasNoKey();
    }
}
