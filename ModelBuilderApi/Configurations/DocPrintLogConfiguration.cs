using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DocPrintLogConfiguration : IEntityTypeConfiguration<DocPrintLog>
{
    public void Configure(EntityTypeBuilder<DocPrintLog> builder)
    {
        builder.ToTable("DocPrintLog");
        builder.HasNoKey();
    }
}
