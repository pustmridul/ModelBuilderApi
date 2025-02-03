using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class TEMP_CUSTOMER_QUOTATIONConfiguration : IEntityTypeConfiguration<TEMP_CUSTOMER_QUOTATION>
{
    public void Configure(EntityTypeBuilder<TEMP_CUSTOMER_QUOTATION> builder)
    {
        builder.ToTable("TEMP_CUSTOMER_QUOTATION");
        builder.HasNoKey();
    }
}
