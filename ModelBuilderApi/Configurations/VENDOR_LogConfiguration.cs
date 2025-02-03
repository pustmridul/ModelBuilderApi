using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VENDOR_LogConfiguration : IEntityTypeConfiguration<VENDOR_Log>
{
    public void Configure(EntityTypeBuilder<VENDOR_Log> builder)
    {
        builder.ToTable("VENDOR_Log");
        builder.HasNoKey();
    }
}
