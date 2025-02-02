using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("USERS");
        builder.HasKey(x => new { x.USERNAME, x.COMPANY_CODE });
    }
}
