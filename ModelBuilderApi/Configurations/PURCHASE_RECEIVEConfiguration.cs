using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PURCHASE_RECEIVEConfiguration : IEntityTypeConfiguration<PURCHASE_RECEIVE>
{
    public void Configure(EntityTypeBuilder<PURCHASE_RECEIVE> builder)
    {
        builder.ToTable("PURCHASE_RECEIVE");
        builder.HasKey(x => new { x.MEMO_NO, x.PURCHASE_DATE, x.VENDOR_CODE, x.STORE_CODE });
    }
}
