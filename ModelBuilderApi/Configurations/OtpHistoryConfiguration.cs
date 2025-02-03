using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class OtpHistoryConfiguration : IEntityTypeConfiguration<OtpHistory>
{
    public void Configure(EntityTypeBuilder<OtpHistory> builder)
    {
        builder.ToTable("OtpHistory");
        builder.HasNoKey();
    }
}
