using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VatIntegrationConfiguration : IEntityTypeConfiguration<VatIntegration>
{
    public void Configure(EntityTypeBuilder<VatIntegration> builder)
    {
        builder.ToTable("VatIntegration");
        builder.HasNoKey();
    }
}
