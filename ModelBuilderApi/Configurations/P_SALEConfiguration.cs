using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class P_SALEConfiguration : IEntityTypeConfiguration<P_SALE>
{
    public void Configure(EntityTypeBuilder<P_SALE> builder)
    {
        builder.ToTable("P_SALE");
        builder.HasNoKey();
    }
}
