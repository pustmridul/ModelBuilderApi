using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_TRANSFER_PERMISSIONConfiguration : IEntityTypeConfiguration<STORE_TRANSFER_PERMISSION>
{
    public void Configure(EntityTypeBuilder<STORE_TRANSFER_PERMISSION> builder)
    {
        builder.ToTable("STORE_TRANSFER_PERMISSION");
        builder.HasNoKey();
    }
}
