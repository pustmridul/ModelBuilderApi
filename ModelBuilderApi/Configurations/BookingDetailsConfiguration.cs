using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class BookingDetailsConfiguration : IEntityTypeConfiguration<BookingDetails>
{
    public void Configure(EntityTypeBuilder<BookingDetails> builder)
    {
        builder.ToTable("BookingDetails");
        builder.HasNoKey();
    }
}
