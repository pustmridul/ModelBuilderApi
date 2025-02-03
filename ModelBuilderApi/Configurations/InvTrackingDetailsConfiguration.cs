using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class InvTrackingDetailsConfiguration : IEntityTypeConfiguration<InvTrackingDetails>
{
    public void Configure(EntityTypeBuilder<InvTrackingDetails> builder)
    {
        builder.ToTable("InvTrackingDetails");
        builder.HasNoKey();
    }
}
