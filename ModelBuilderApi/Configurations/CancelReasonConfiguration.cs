using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CancelReasonConfiguration : IEntityTypeConfiguration<CancelReason>
{
    public void Configure(EntityTypeBuilder<CancelReason> builder)
    {
        builder.ToTable("CancelReason");
        builder.HasNoKey();
    }
}
