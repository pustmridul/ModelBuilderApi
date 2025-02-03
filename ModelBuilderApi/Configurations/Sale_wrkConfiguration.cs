using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class Sale_wrkConfiguration : IEntityTypeConfiguration<Sale_wrk>
{
    public void Configure(EntityTypeBuilder<Sale_wrk> builder)
    {
        builder.ToTable("Sale_wrk");
        builder.HasNoKey();
    }
}
