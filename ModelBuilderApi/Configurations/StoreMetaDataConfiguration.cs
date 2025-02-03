using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class StoreMetaDataConfiguration : IEntityTypeConfiguration<StoreMetaData>
{
    public void Configure(EntityTypeBuilder<StoreMetaData> builder)
    {
        builder.ToTable("StoreMetaData");
        builder.HasNoKey();
    }
}
