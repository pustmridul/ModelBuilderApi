using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STOREConfiguration : IEntityTypeConfiguration<STORE>
{
    public void Configure(EntityTypeBuilder<STORE> builder)
    {
        builder.ToTable("STORE");
        builder.HasKey(x => new { x.STORE_NAME, x.COMPANY_CODE });
    }
}
