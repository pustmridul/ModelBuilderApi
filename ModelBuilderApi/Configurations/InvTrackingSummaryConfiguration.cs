using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class InvTrackingSummaryConfiguration : IEntityTypeConfiguration<InvTrackingSummary>
{
    public void Configure(EntityTypeBuilder<InvTrackingSummary> builder)
    {
        builder.ToTable("InvTrackingSummary");
        builder.HasNoKey();
    }
}
