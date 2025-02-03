using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_DML_CUSTOMER_WISEConfiguration : IEntityTypeConfiguration<STORE_DML_CUSTOMER_WISE>
{
    public void Configure(EntityTypeBuilder<STORE_DML_CUSTOMER_WISE> builder)
    {
        builder.ToTable("STORE_DML_CUSTOMER_WISE");
        builder.HasNoKey();
    }
}
