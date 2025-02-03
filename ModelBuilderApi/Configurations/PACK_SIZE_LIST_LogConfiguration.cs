using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PACK_SIZE_LIST_LogConfiguration : IEntityTypeConfiguration<PACK_SIZE_LIST_Log>
{
    public void Configure(EntityTypeBuilder<PACK_SIZE_LIST_Log> builder)
    {
        builder.ToTable("PACK_SIZE_LIST_Log");
        builder.HasNoKey();
    }
}
