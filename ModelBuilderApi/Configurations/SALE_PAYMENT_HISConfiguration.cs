using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SALE_PAYMENT_HISConfiguration : IEntityTypeConfiguration<SALE_PAYMENT_HIS>
{
    public void Configure(EntityTypeBuilder<SALE_PAYMENT_HIS> builder)
    {
        builder.ToTable("SALE_PAYMENT_HIS");
        builder.HasNoKey();
    }
}
