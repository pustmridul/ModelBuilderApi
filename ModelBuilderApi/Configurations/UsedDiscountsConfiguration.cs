using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class UsedDiscountsConfiguration : IEntityTypeConfiguration<UsedDiscounts>
{
    public void Configure(EntityTypeBuilder<UsedDiscounts> builder)
    {
        builder.ToTable("UsedDiscounts");
        builder.HasNoKey();
    }
}
