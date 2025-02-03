using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CashStatementConfiguration : IEntityTypeConfiguration<CashStatement>
{
    public void Configure(EntityTypeBuilder<CashStatement> builder)
    {
        builder.ToTable("CashStatement");
        builder.HasKey(x => new { x.COMPANY_CODE, x.STORE_CODE, x.DATE});
    }
}
