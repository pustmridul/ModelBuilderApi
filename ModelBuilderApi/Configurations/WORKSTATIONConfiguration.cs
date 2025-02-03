using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class WORKSTATIONConfiguration : IEntityTypeConfiguration<WORKSTATION>
{
    public void Configure(EntityTypeBuilder<WORKSTATION> builder)
    {
        builder.ToTable("WORKSTATION");
        builder.HasKey(x => new { x.MAC_ADDR });
    }
}
