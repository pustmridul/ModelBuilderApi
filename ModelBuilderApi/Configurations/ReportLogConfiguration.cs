using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ReportLogConfiguration : IEntityTypeConfiguration<ReportLog>
{
    public void Configure(EntityTypeBuilder<ReportLog> builder)
    {
        builder.ToTable("ReportLog");
        builder.HasKey(x => new { x.serial });
    }
}
