using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ConsoleSetupConfiguration : IEntityTypeConfiguration<ConsoleSetup>
{
    public void Configure(EntityTypeBuilder<ConsoleSetup> builder)
    {
        builder.ToTable("ConsoleSetup");
        builder.HasNoKey();
    }
}
