using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ReportSectionConfiguration : IEntityTypeConfiguration<ReportSection>
{
    public void Configure(EntityTypeBuilder<ReportSection> builder)
    {
        builder.ToTable("ReportSection");
        builder.HasNoKey();
    }
}
