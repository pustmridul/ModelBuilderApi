using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_DELIVERY_DETAILS_DISCP_LOGConfiguration : IEntityTypeConfiguration<STORE_DELIVERY_DETAILS_DISCP_LOG>
{
    public void Configure(EntityTypeBuilder<STORE_DELIVERY_DETAILS_DISCP_LOG> builder)
    {
        builder.ToTable("STORE_DELIVERY_DETAILS_DISCP_LOG");
        builder.HasNoKey();
    }
}
