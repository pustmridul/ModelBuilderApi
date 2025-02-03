using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_REQUISITIONConfiguration : IEntityTypeConfiguration<STORE_REQUISITION>
{
    public void Configure(EntityTypeBuilder<STORE_REQUISITION> builder)
    {
        builder.ToTable("STORE_REQUISITION");
        builder.HasNoKey();
    }
}
