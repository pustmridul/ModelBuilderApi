using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SUBCATEGORY_VARIANCEConfiguration : IEntityTypeConfiguration<SUBCATEGORY_VARIANCE>
{
    public void Configure(EntityTypeBuilder<SUBCATEGORY_VARIANCE> builder)
    {
        builder.ToTable("SUBCATEGORY_VARIANCE");
        builder.HasNoKey();
    }
}
