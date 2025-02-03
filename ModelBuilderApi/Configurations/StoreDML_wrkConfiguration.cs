using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreDML_wrkConfiguration : IEntityTypeConfiguration<StoreDML_wrk>
{
    public void Configure(EntityTypeBuilder<StoreDML_wrk> builder)
    {
        builder.ToTable("StoreDML_wrk");
        builder.HasNoKey();
    }
}
