using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class DO_CompanyConfiguration : IEntityTypeConfiguration<DO_Company>
{
    public void Configure(EntityTypeBuilder<DO_Company> builder)
    {
        builder.ToTable("DO_Company");
        builder.HasNoKey();
    }
}
