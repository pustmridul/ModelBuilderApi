using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class EMPLOYEEConfiguration : IEntityTypeConfiguration<EMPLOYEE>
{
    public void Configure(EntityTypeBuilder<EMPLOYEE> builder)
    {
        builder.ToTable("EMPLOYEE");
        builder.HasKey(x=> new { x.EMPLOYEE_CODE, x.COMPANY_CODE });
    }
}
