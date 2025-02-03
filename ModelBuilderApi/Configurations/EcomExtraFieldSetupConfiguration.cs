using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class EcomExtraFieldSetupConfiguration : IEntityTypeConfiguration<EcomExtraFieldSetup>
{
    public void Configure(EntityTypeBuilder<EcomExtraFieldSetup> builder)
    {
        builder.ToTable("EcomExtraFieldSetup");
        builder.HasNoKey();
    }
}
