using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreSetupConfiguration : IEntityTypeConfiguration<StoreSetup>
{
    public void Configure(EntityTypeBuilder<StoreSetup> builder)
    {
        builder.ToTable("StoreSetup");
        builder.HasNoKey();
    }
}
