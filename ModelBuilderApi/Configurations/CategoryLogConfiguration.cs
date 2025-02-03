using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CategoryLogConfiguration : IEntityTypeConfiguration<CategoryLog>
{
    public void Configure(EntityTypeBuilder<CategoryLog> builder)
    {
        builder.ToTable("CATEGORY_Log");
        builder.HasNoKey();
    }
}
