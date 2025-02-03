using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class WorkOrderGLConfiguration : IEntityTypeConfiguration<WorkOrderGL>
{
    public void Configure(EntityTypeBuilder<WorkOrderGL> builder)
    {
        builder.ToTable("WorkOrderGL");
        builder.HasNoKey();
    }
}
