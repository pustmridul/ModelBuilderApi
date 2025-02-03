using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class InvTrackingDetailsUpdateConfiguration : IEntityTypeConfiguration<InvTrackingDetailsUpdate>
{
    public void Configure(EntityTypeBuilder<InvTrackingDetailsUpdate> builder)
    {
        builder.ToTable("InvTrackingDetailsUpdate");
        builder.HasNoKey();
    }
}
