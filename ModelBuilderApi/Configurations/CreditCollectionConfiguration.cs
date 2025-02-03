using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CreditCollectionConfiguration : IEntityTypeConfiguration<CreditCollection>
{
    public void Configure(EntityTypeBuilder<CreditCollection> builder)
    {
        builder.ToTable("CREDIT_COLLECTION");
        builder.HasKey(x => new { x.COMPANY_CODE, x.STORE_CODE, x.TERMINAL_NO, x.VOUCHER_NO });
    }
}
