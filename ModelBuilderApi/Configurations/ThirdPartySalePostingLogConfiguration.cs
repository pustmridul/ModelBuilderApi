using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ThirdPartySalePostingLogConfiguration : IEntityTypeConfiguration<ThirdPartySalePostingLog>
{
    public void Configure(EntityTypeBuilder<ThirdPartySalePostingLog> builder)
    {
        builder.ToTable("ThirdPartySalePostingLog");
        builder.HasKey(x => new { x.AutoId });
    }
}
