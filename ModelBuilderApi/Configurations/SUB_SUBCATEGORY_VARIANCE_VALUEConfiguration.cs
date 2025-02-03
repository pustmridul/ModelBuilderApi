using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SUB_SUBCATEGORY_VARIANCE_VALUEConfiguration : IEntityTypeConfiguration<SUB_SUBCATEGORY_VARIANCE_VALUE>
{
    public void Configure(EntityTypeBuilder<SUB_SUBCATEGORY_VARIANCE_VALUE> builder)
    {
        builder.ToTable("SUB_SUBCATEGORY_VARIANCE_VALUE");
        builder.HasNoKey();
    }
}
