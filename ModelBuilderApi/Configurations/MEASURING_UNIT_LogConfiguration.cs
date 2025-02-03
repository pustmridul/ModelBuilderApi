using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class MEASURING_UNIT_LogConfiguration : IEntityTypeConfiguration<MEASURING_UNIT_Log>
{
    public void Configure(EntityTypeBuilder<MEASURING_UNIT_Log> builder)
    {
        builder.ToTable("MEASURING_UNIT_Log");
        builder.HasKey(x=> new { x.DESCRIPTION, x.COMPANY_CODE });
    }
}
