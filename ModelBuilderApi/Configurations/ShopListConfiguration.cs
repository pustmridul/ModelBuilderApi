using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ShopListConfiguration : IEntityTypeConfiguration<ShopList>
{
    public void Configure(EntityTypeBuilder<ShopList> builder)
    {
        builder.ToTable("ShopList");
        builder.HasKey(x => new { x.ShopID });
    }
}
