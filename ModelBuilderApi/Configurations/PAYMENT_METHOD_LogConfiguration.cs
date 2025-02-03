using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PAYMENT_METHOD_LogConfiguration : IEntityTypeConfiguration<PAYMENT_METHOD_Log>
{
    public void Configure(EntityTypeBuilder<PAYMENT_METHOD_Log> builder)
    {
        builder.ToTable("PAYMENT_METHOD_Log");
        builder.HasNoKey();
    }
}
