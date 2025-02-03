using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_DMLConfiguration : IEntityTypeConfiguration<STORE_DML>
{
    public void Configure(EntityTypeBuilder<STORE_DML> builder)
    {
        builder.ToTable("STORE_DML");
        builder.HasNoKey();
    }
}
