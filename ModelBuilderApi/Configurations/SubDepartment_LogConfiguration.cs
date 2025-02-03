using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SubDepartment_LogConfiguration : IEntityTypeConfiguration<SubDepartment_Log>
{
    public void Configure(EntityTypeBuilder<SubDepartment_Log> builder)
    {
        builder.ToTable("SubDepartment_Log");
        builder.HasKey(x => new { x.CODE, x.COMPANY_CODE });
    }
}
