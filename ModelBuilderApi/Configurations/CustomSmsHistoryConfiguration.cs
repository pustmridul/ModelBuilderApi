using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomSmsHistoryConfiguration : IEntityTypeConfiguration<CustomSmsHistory>
{
    public void Configure(EntityTypeBuilder<CustomSmsHistory> builder)
    {
        builder.ToTable("CustomSmsHistory");
        builder.HasNoKey();
    }
}
