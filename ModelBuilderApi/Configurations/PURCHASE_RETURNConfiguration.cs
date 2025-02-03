using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class PURCHASE_RETURNConfiguration : IEntityTypeConfiguration<PURCHASE_RETURN>
{
    public void Configure(EntityTypeBuilder<PURCHASE_RETURN> builder)
    {
        builder.ToTable("PURCHASE_RETURN");
        builder.HasKey(x => new { x.CHALLAN_NO, x.REF_NO, x.COMPANY_CODE, x.STORE_CODE, x.VENDOR_CODE });
    }
}
