using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class EMPLOYEE_DESIGNATION_LogConfiguration : IEntityTypeConfiguration<EMPLOYEE_DESIGNATION_Log>
{
    public void Configure(EntityTypeBuilder<EMPLOYEE_DESIGNATION_Log> builder)
    {
        builder.ToTable("EMPLOYEE_DESIGNATION_Log");
        builder.HasNoKey();
    }
}
