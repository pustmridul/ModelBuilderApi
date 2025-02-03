using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SUB_CATEGORY_LogConfiguration : IEntityTypeConfiguration<SUB_CATEGORY_Log>
{
    public void Configure(EntityTypeBuilder<SUB_CATEGORY_Log> builder)
    {
        builder.ToTable("SUB_CATEGORY_Log");
        builder.HasNoKey();
    }
}
