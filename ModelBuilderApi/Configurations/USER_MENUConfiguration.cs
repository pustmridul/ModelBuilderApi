using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class USER_MENUConfiguration : IEntityTypeConfiguration<USER_MENU>
{
    public void Configure(EntityTypeBuilder<USER_MENU> builder)
    {
        builder.ToTable("USER_MENU");
        builder.HasNoKey();
    }
}
