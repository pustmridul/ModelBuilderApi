using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SubSubcategoryConfiguration : IEntityTypeConfiguration<SubSubcategory>
{
    public void Configure(EntityTypeBuilder<SubSubcategory> builder)
    {
        builder.ToTable("SubSubcategory");
        builder.HasKey(x => new { x.SUB_SUBCATEGORY_NAME, x.COMPANY_CODE });
    }
}
