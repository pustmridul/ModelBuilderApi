using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class MENUConfiguration : IEntityTypeConfiguration<MENU>
{
    public void Configure(EntityTypeBuilder<MENU> builder)
    {
        builder.ToTable("MENU");
        builder.HasNoKey();
    }
}
