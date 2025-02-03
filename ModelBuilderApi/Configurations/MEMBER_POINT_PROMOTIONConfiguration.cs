using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class MEMBER_POINT_PROMOTIONConfiguration : IEntityTypeConfiguration<MEMBER_POINT_PROMOTION>
{
    public void Configure(EntityTypeBuilder<MEMBER_POINT_PROMOTION> builder)
    {
        builder.ToTable("MEMBER_POINT_PROMOTION");
        builder.HasNoKey();
    }
}
