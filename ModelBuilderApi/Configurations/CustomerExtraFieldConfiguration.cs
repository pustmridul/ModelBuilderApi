using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class CustomerExtraFieldConfiguration : IEntityTypeConfiguration<CustomerExtraField>
{
    public void Configure(EntityTypeBuilder<CustomerExtraField> builder)
    {
        builder.ToTable("CustomerExtraField");
        builder.HasNoKey();
    }
}
