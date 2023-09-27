using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CIRCULAR_DISCOUNT")]
    public class CIRCULAR_DISCOUNT
    {
        public string? PROMOTION_CODE { get; set; }
        public DateTime VALID_FROM { get; set; }
        public DateTime? VALID_TO { get; set; }
        public string? BARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal MRP_DISC_PERCENT { get; set; }
        public decimal MRP_DISC_AMOUNT { get; set; }
        public decimal? WSP_DISC_PERCENT { get; set; }
        public decimal? WSP_DISC_AMOUNT { get; set; }
        public decimal? PRICE1_DISC_PERCENT { get; set; }
        public decimal? PRICE1_DISC_AMOUNT { get; set; }
        public decimal? PRICE2_DISC_PERCENT { get; set; }
        public decimal? PRICE2_DISC_AMOUNT { get; set; }
        public decimal? PRICE3_DISC_PERCENT { get; set; }
        public decimal? PRICE3_DISC_AMOUNT { get; set; }
        public decimal? PRICE4_DISC_PERCENT { get; set; }
        public decimal? PRICE4_DISC_AMOUNT { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }

    }
}
