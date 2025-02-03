using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DayCloseLogConfiguration : IEntityTypeConfiguration<DayCloseLog>
{
    public void Configure(EntityTypeBuilder<DayCloseLog> builder)
    {
        builder.ToTable("DayCloseLog");
        builder.HasKey(x=>new { x.COMPANY_CODE, x.STORE_CODE, x.CLOSED_DT, x.STATUS });
    }
}
