using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ROLE_MENUConfiguration : IEntityTypeConfiguration<ROLE_MENU>
{
    public void Configure(EntityTypeBuilder<ROLE_MENU> builder)
    {
        builder.ToTable("ROLE_MENU");
        builder.HasNoKey();
    }
}
