using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class LabelSetupConfiguration : IEntityTypeConfiguration<LabelSetup>
{
    public void Configure(EntityTypeBuilder<LabelSetup> builder)
    {
        builder.ToTable("LabelSetup");
        builder.HasNoKey();
    }
}
