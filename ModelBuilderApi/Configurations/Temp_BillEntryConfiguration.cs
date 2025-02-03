using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class Temp_BillEntryConfiguration : IEntityTypeConfiguration<Temp_BillEntry>
{
    public void Configure(EntityTypeBuilder<Temp_BillEntry> builder)
    {
        builder.ToTable("Temp_BillEntry");
        builder.HasNoKey();
    }
}
