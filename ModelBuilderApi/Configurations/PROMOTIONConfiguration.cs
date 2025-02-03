using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PROMOTIONConfiguration : IEntityTypeConfiguration<PROMOTION>
{
    public void Configure(EntityTypeBuilder<PROMOTION> builder)
    {
        builder.ToTable("PROMOTION");
        builder.HasKey(x => new { x.PROMOTION_CODE, x.COMPANY_CODE });
    }
}
