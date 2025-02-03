using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class EcomMessageConfiguration : IEntityTypeConfiguration<EcomMessage>
{
    public void Configure(EntityTypeBuilder<EcomMessage> builder)
    {
        builder.ToTable("EcomMessage");
        builder.HasNoKey();
    }
}
