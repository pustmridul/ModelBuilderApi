using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PAYMENT_METHODConfiguration : IEntityTypeConfiguration<PAYMENT_METHOD>
{
    public void Configure(EntityTypeBuilder<PAYMENT_METHOD> builder)
    {
        builder.ToTable("PAYMENT_METHOD");
        builder.HasKey(x=> new { x.NAME, x.COMPANY_CODE });
    }
}
