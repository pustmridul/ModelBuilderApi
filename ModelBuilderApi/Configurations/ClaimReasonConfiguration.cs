using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ClaimReasonConfiguration : IEntityTypeConfiguration<ClaimReason>
{
    public void Configure(EntityTypeBuilder<ClaimReason> builder)
    {
        builder.ToTable("CLAIM_REASON");
        builder.HasKey(x => new { x.CODE });
    }
}
