using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class VENDORConfiguration : IEntityTypeConfiguration<VENDOR>
{
    public void Configure(EntityTypeBuilder<VENDOR> builder)
    {
        builder.ToTable("VENDOR");
        builder.HasNoKey();
    }
}
