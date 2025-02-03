using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CUSTOMER_QUOTATIONConfiguration : IEntityTypeConfiguration<CUSTOMER_QUOTATION>
{
    public void Configure(EntityTypeBuilder<CUSTOMER_QUOTATION> builder)
    {
        builder.ToTable("CUSTOMER_QUOTATION");
        builder.HasNoKey();
    }
}
