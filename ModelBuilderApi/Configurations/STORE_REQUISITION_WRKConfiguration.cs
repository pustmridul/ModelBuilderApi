using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_REQUISITION_WRKConfiguration : IEntityTypeConfiguration<STORE_REQUISITION_WRK>
{
    public void Configure(EntityTypeBuilder<STORE_REQUISITION_WRK> builder)
    {
        builder.ToTable("STORE_REQUISITION_WRK");
        builder.HasNoKey();
    }
}
