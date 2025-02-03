using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class MEASURING_UNITConfiguration : IEntityTypeConfiguration<MEASURING_UNIT>
{
    public void Configure(EntityTypeBuilder<MEASURING_UNIT> builder)
    {
        builder.ToTable("MEASURING_UNIT");
        builder.HasKey(x=> new { x.DESCRIPTION, x.COMPANY_CODE });
    }
}
