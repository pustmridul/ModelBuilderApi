using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class InvTrackingAuditorDetailsConfiguration : IEntityTypeConfiguration<InvTrackingAuditorDetails>
{
    public void Configure(EntityTypeBuilder<InvTrackingAuditorDetails> builder)
    {
        builder.ToTable("InvTrackingAuditorDetails");
        builder.HasNoKey();
    }
}
