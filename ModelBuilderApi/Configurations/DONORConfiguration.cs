using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DONORConfiguration : IEntityTypeConfiguration<DONOR>
{
    public void Configure(EntityTypeBuilder<DONOR> builder)
    {
        builder.ToTable("Department");
        builder.HasNoKey();
    }
}
