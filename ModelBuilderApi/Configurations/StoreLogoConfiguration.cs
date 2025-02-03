using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreLogoConfiguration : IEntityTypeConfiguration<StoreLogo>
{
    public void Configure(EntityTypeBuilder<StoreLogo> builder)
    {
        builder.ToTable("StoreLogo");
        builder.HasNoKey();
    }
}
