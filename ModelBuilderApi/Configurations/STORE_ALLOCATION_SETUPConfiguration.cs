using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_ALLOCATION_SETUPConfiguration : IEntityTypeConfiguration<STORE_ALLOCATION_SETUP>
{
    public void Configure(EntityTypeBuilder<STORE_ALLOCATION_SETUP> builder)
    {
        builder.ToTable("STORE_ALLOCATION_SETUP");
        builder.HasKey(x => new { x.COMPANY_CODE });
    }
}
