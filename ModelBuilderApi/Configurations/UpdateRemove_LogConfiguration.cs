using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class UpdateRemove_LogConfiguration : IEntityTypeConfiguration<UpdateRemove_Log>
{
    public void Configure(EntityTypeBuilder<UpdateRemove_Log> builder)
    {
        builder.ToTable("UpdateRemove_Log");
        builder.HasNoKey();
    }
}
