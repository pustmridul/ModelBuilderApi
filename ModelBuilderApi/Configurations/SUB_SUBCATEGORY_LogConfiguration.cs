using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SUB_SUBCATEGORY_LogConfiguration : IEntityTypeConfiguration<SUB_SUBCATEGORY_Log>
{
    public void Configure(EntityTypeBuilder<SUB_SUBCATEGORY_Log> builder)
    {
        builder.ToTable("SUB_SUBCATEGORY_Log");
        builder.HasNoKey();
    }
}
