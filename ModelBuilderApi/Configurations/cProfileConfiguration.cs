using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class cProfileConfiguration : IEntityTypeConfiguration<cProfile>
{
    public void Configure(EntityTypeBuilder<cProfile> builder)
    {
        builder.ToTable("cProfile");
        builder.HasNoKey();
    }
}
