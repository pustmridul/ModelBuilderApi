using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class WeighingScaleSetupConfiguration : IEntityTypeConfiguration<WeighingScaleSetup>
{
    public void Configure(EntityTypeBuilder<WeighingScaleSetup> builder)
    {
        builder.ToTable("WeighingScaleSetup");
        builder.HasNoKey();
    }
}
