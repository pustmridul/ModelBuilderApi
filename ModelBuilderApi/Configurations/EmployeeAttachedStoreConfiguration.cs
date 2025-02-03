using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class EmployeeAttachedStoreConfiguration : IEntityTypeConfiguration<EmployeeAttachedStore>
{
    public void Configure(EntityTypeBuilder<EmployeeAttachedStore> builder)
    {
        builder.ToTable("EmployeeAttachedStore");
        builder.HasNoKey();
    }
}
