using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_SUPERVISORConfiguration : IEntityTypeConfiguration<STORE_SUPERVISOR>
{
    public void Configure(EntityTypeBuilder<STORE_SUPERVISOR> builder)
    {
        builder.ToTable("STORE_SUPERVISOR");
        builder.HasNoKey();
    }
}
