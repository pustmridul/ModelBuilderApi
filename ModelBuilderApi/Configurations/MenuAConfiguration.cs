using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class MenuAConfiguration : IEntityTypeConfiguration<MenuA>
{
    public void Configure(EntityTypeBuilder<MenuA> builder)
    {
        builder.ToTable("MenuA");
        builder.HasNoKey();
    }
}
