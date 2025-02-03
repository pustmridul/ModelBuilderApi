using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class TEMP_CIRCULAR_DISCOUNTConfiguration : IEntityTypeConfiguration<TEMP_CIRCULAR_DISCOUNT>
{
    public void Configure(EntityTypeBuilder<TEMP_CIRCULAR_DISCOUNT> builder)
    {
        builder.ToTable("TEMP_CIRCULAR_DISCOUNT");
        builder.HasNoKey();
    }
}
