using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class PROMOTION
    {
       
        public string PROMOTION_CODE { get; set; }
        public string? PROMOTION_NAME { get; set; }
        public string? PROMOTION_TYPE { get; set; }
        public string? PROMOTION_NATURE { get; set; }
        public string? BUY_QTY { get; set; }
        public string? GET_QTY { get; set; }
        public DateTime VALID_FROM { get; set; }
        public DateTime? VALID_TO { get; set; }
        public decimal ACTUAL_PRICE { get; set; }
        public decimal PROMOTION_PRICE { get; set; }
      
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? VALID_FROM_TIME { get; set; }
        public string? VALID_TO_TIME { get; set; }
        public decimal PROMOTION_VAT { get; set; }
        public decimal IS_PRICE_INCLD_VAT { get; set; }
        public decimal SD_AMT { get; set; }
        public string? COUPON_NO { get; set; }
        public string? COUPON_TYPE { get; set; }
        public decimal? COUPON_VALUE { get; set; }
        public decimal? MAX_DISC_AMT { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string? REMARKS { get; set; }
        public int MAX_REDEMPTION_LIMIT { get; set; }
        public int? NUM_OF_REDEMPTION { get; set; }
        public decimal? INVOICE_VALUE { get; set; }
        public DateTime? INACTIVE_DATE { get; set; }
        public string? INACTIVE_TIME { get; set; }
        public string? INACTIVE_BY { get; set; }
        public DateTime? INACTIVE_ENTRY_DATE { get; set; }
        public string INACTIVE_STATUS { get; set; }
        public DateTime? EXTEND_DATE { get; set; }
        public string? EXTEND_TIME { get; set; }
        public string? EXTEND_BY { get; set; }
        public DateTime? EXTEND_ENTRY_DATE { get; set; }
        public string EXTEND_STATUS { get; set; }
        public string? PaymentMethod { get; set; }
        public int MIN_NUM_OF_ITEM { get; set; }
        public decimal QTY_LIMIT { get; set; }
    }
}
