using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ConsoleTypeConfiguration : IEntityTypeConfiguration<ConsoleType>
{
    public void Configure(EntityTypeBuilder<ConsoleType> builder)
    {
        builder.ToTable("ConsoleType");
        builder.HasNoKey();
    }
}
