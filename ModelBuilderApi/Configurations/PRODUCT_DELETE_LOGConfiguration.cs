using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PRODUCT_DELETE_LOGConfiguration : IEntityTypeConfiguration<PRODUCT_DELETE_LOG>
{
    public void Configure(EntityTypeBuilder<PRODUCT_DELETE_LOG> builder)
    {
        builder.ToTable("PRODUCT_DELETE_LOG");
        builder.HasNoKey();
    }
}
