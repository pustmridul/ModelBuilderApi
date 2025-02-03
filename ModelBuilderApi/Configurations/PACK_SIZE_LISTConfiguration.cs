using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PACK_SIZE_LISTConfiguration : IEntityTypeConfiguration<PACK_SIZE_LIST>
{
    public void Configure(EntityTypeBuilder<PACK_SIZE_LIST> builder)
    {
        builder.ToTable("PACK_SIZE_LIST");
        builder.HasKey(x=> new { x.DESCRIPTION, x.COMPANY_CODE });
    }
}
