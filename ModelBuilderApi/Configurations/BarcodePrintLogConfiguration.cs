using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class BarcodePrintLogConfiguration : IEntityTypeConfiguration<BarcodePrintLog>
{
    public void Configure(EntityTypeBuilder<BarcodePrintLog> builder)
    {
        builder.ToTable("BarcodePrintLog");
        builder.HasNoKey();
    }
}
