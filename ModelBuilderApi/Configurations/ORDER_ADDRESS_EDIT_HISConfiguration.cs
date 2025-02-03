using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class ORDER_ADDRESS_EDIT_HISConfiguration : IEntityTypeConfiguration<ORDER_ADDRESS_EDIT_HIS>
{
    public void Configure(EntityTypeBuilder<ORDER_ADDRESS_EDIT_HIS> builder)
    {
        builder.ToTable("ORDER_ADDRESS_EDIT_HIS");
        builder.HasNoKey();
    }
}
