using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ProductColumnDefineConfiguration : IEntityTypeConfiguration<ProductColumnDefine>
{
    public void Configure(EntityTypeBuilder<ProductColumnDefine> builder)
    {
        builder.ToTable("ProductColumnDefine");
        builder.HasNoKey();
    }
}
