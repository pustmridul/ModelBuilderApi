using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PURCHASE_ORDERConfiguration : IEntityTypeConfiguration<PURCHASE_ORDER>
{
    public void Configure(EntityTypeBuilder<PURCHASE_ORDER> builder)
    {
        builder.ToTable("PURCHASE_ORDER");
        builder.HasKey(x => new {  x.COMPANY_CODE, x.STORE_CODE, x.ORDER_NO });
    }
}
