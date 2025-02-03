using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SSUMMARYConfiguration : IEntityTypeConfiguration<SSUMMARY>
{
    public void Configure(EntityTypeBuilder<SSUMMARY> builder)
    {
        builder.ToTable("SSUMMARY");
        builder.HasKey(x => new { x.INVOICE_NO, x.STORE_CODE });
    }
}
