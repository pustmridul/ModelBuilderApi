using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class EMPLOYEE_DESIGNATIONConfiguration : IEntityTypeConfiguration<EMPLOYEE_DESIGNATION>
{
    public void Configure(EntityTypeBuilder<EMPLOYEE_DESIGNATION> builder)
    {
        builder.ToTable("EMPLOYEE_DESIGNATION");
        builder.HasKey(x=> new { x.DESCRIPTION, x.COMPANY_CODE });
    }
}
