using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.ToTable("App_User");
        builder.HasKey(x => new { x.PhoneNo, x.DeviceId, x.StoreCode});
    }
}
