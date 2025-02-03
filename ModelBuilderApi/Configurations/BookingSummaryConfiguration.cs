using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class BookingSummaryConfiguration : IEntityTypeConfiguration<BookingSummary>
{
    public void Configure(EntityTypeBuilder<BookingSummary> builder)
    {
        builder.ToTable("BookingSummary");
        builder.HasKey(x => new { x.BOOKING_NO });
    }
}
