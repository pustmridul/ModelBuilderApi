using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STOREDELIVERYRECEIVEConfiguration : IEntityTypeConfiguration<STOREDELIVERYRECEIVE>
{
    public void Configure(EntityTypeBuilder<STOREDELIVERYRECEIVE> builder)
    {
        builder.ToTable("STOREDELIVERYRECEIVE");
        builder.HasNoKey();
    }
}
