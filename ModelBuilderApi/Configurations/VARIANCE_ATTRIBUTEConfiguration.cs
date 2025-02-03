using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VARIANCE_ATTRIBUTEConfiguration : IEntityTypeConfiguration<VARIANCE_ATTRIBUTE>
{
    public void Configure(EntityTypeBuilder<VARIANCE_ATTRIBUTE> builder)
    {
        builder.ToTable("VARIANCE_ATTRIBUTE");
        builder.HasNoKey();
    }
}
