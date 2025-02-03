using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ExcessCreditLimitConfiguration : IEntityTypeConfiguration<ExcessCreditLimit>
{
    public void Configure(EntityTypeBuilder<ExcessCreditLimit> builder)
    {
        builder.ToTable("ExcessCreditLimit");
        builder.HasKey(x=> new { x.CODE });
    }
}
