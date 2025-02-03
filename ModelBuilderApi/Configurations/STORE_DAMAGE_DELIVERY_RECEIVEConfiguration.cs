using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class STORE_DAMAGE_DELIVERY_RECEIVEConfiguration : IEntityTypeConfiguration<STORE_DAMAGE_DELIVERY_RECEIVE>
{
    public void Configure(EntityTypeBuilder<STORE_DAMAGE_DELIVERY_RECEIVE> builder)
    {
        builder.ToTable("STORE_DAMAGE_DELIVERY_RECEIVE");
        builder.HasKey(x => new { x.CHALLAN_NO, x.SAL_BARCODE });
    }
}
