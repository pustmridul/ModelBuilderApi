using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ReportHeadConfiguration : IEntityTypeConfiguration<ReportHead>
{
    public void Configure(EntityTypeBuilder<ReportHead> builder)
    {
        builder.ToTable("ReportHead");
        builder.HasNoKey();
    }
}
