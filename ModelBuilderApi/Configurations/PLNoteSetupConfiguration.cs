using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PLNoteSetupConfiguration : IEntityTypeConfiguration<PLNoteSetup>
{
    public void Configure(EntityTypeBuilder<PLNoteSetup> builder)
    {
        builder.ToTable("PLNoteSetup");
        builder.HasKey(x=> new { x.Code });
    }
}
