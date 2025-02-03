using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomerType_LogConfiguration : IEntityTypeConfiguration<CustomerType_Log>
{
    public void Configure(EntityTypeBuilder<CustomerType_Log> builder)
    {
        builder.ToTable("CustomerType_Log");
        builder.HasNoKey();
    }
}
