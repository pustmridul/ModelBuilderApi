using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class InvTrackingSummaryTempConfiguration : IEntityTypeConfiguration<InvTrackingSummaryTemp>
{
    public void Configure(EntityTypeBuilder<InvTrackingSummaryTemp> builder)
    {
        builder.ToTable("InvTrackingSummaryTemp");
        builder.HasNoKey();
    }
}
