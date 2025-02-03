using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class SmsGatewayConfiguration : IEntityTypeConfiguration<SmsGateway>
{
    public void Configure(EntityTypeBuilder<SmsGateway> builder)
    {
        builder.ToTable("SmsGateway");
        builder.HasNoKey();
    }
}
