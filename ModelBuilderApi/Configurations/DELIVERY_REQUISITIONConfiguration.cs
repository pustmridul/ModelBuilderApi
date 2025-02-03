using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DELIVERY_REQUISITIONConfiguration : IEntityTypeConfiguration<DELIVERY_REQUISITION>
{
    public void Configure(EntityTypeBuilder<DELIVERY_REQUISITION> builder)
    {
        builder.ToTable("DELIVERY_REQUISITION");
        builder.HasNoKey();
    }
}
