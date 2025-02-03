using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SUB_SUBCATEGORY_VARIANCEConfiguration : IEntityTypeConfiguration<SUB_SUBCATEGORY_VARIANCE>
{
    public void Configure(EntityTypeBuilder<SUB_SUBCATEGORY_VARIANCE> builder)
    {
        builder.ToTable("SUB_SUBCATEGORY_VARIANCE");
        builder.HasNoKey();
    }
}
