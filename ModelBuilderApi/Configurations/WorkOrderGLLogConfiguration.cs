using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class WorkOrderGLLogConfiguration : IEntityTypeConfiguration<WorkOrderGLLog>
{
    public void Configure(EntityTypeBuilder<WorkOrderGLLog> builder)
    {
        builder.ToTable("WorkOrderGLLog");
        builder.HasNoKey();
    }
}
