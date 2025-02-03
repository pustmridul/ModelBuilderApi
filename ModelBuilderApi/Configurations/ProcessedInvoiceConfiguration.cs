using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ProcessedInvoiceConfiguration : IEntityTypeConfiguration<ProcessedInvoice>
{
    public void Configure(EntityTypeBuilder<ProcessedInvoice> builder)
    {
        builder.ToTable("ProcessedInvoice");
        builder.HasNoKey();
    }
}
