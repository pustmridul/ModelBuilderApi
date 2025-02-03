using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_HISConfiguration : IEntityTypeConfiguration<PRODUCT_HIS>
{
    public void Configure(EntityTypeBuilder<PRODUCT_HIS> builder)
    {
        builder.ToTable("PRODUCT_HIS");
        builder.HasNoKey();
    }
}
