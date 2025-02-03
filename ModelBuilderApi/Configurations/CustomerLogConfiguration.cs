using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomerLogConfiguration : IEntityTypeConfiguration<CustomerLog>
{
    public void Configure(EntityTypeBuilder<CustomerLog> builder)
    {
        builder.ToTable("CUSTOMER_Log");
        builder.HasKey(x => new { x.ID });
    }
}
