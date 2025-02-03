using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PromotionCustomerTagConfiguration : IEntityTypeConfiguration<PromotionCustomerTag>
{
    public void Configure(EntityTypeBuilder<PromotionCustomerTag> builder)
    {
        builder.ToTable("PromotionCustomerTag");
        builder.HasNoKey();
    }
}
