using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class LoyaltyPointsHistoryConfiguration : IEntityTypeConfiguration<LoyaltyPointsHistory>
{
    public void Configure(EntityTypeBuilder<LoyaltyPointsHistory> builder)
    {
        builder.ToTable("LoyaltyPointsHistory");
        builder.HasKey(x=> new { x.CustomerID, x.OrderID });
    }
}
