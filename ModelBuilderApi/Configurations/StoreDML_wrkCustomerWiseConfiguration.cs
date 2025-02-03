using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreDML_wrkCustomerWiseConfiguration : IEntityTypeConfiguration<StoreDML_wrkCustomerWise>
{
    public void Configure(EntityTypeBuilder<StoreDML_wrkCustomerWise> builder)
    {
        builder.ToTable("StoreDML_wrkCustomerWise");
        builder.HasNoKey();
    }
}
