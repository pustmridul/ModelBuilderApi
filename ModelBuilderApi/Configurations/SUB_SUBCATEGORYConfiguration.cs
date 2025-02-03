using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SUB_SUBCATEGORYConfiguration : IEntityTypeConfiguration<SUB_SUBCATEGORY>
{
    public void Configure(EntityTypeBuilder<SUB_SUBCATEGORY> builder)
    {
        builder.ToTable("SUB_SUBCATEGORY");
        builder.HasKey(x => new { x.SUB_SUBCATEGORY_NAME, x.COMPANY_CODE });
    }
}
