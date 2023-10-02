using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PURCHASE_RETURN_DETAILS")]
    public class PURCHASE_RETURN_DETAILS
    {
        [Key]
        public string CHALLAN_NO { get; set; }
    
        public DateTime? RTN_DT { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]
        public string STORE_CODE { get; set; }
        public string? BARCODE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public decimal CPU { get; set; }
        public decimal RTN_QTY { get; set; }
        public decimal? AMOUNT { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string? VENDOR_CODE { get; set; }
        [Key]
        public string SAL_BARCODE { get; set; }
        [Key]
        public decimal SAL_PRICE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? IS_GIFT { get; set; }
        public decimal? SL { get; set; }
        public string? REASON { get; set; }
        public decimal? VAT_PERCENT { get; set; }
        public string? STATUS { get; set; }
        public decimal? RTN_PUR_QTY { get; set; }
        public decimal? RTN_FREE_QTY { get; set; }
        public decimal? RTN_DISC_AMT { get; set; }
        public decimal? RTN_VAT_AMT { get; set; }
        public decimal? RTN_FREE_AMT { get; set; }
        public string? RCV_NO { get; set; }
        public DateTime? RCV_DATE { get; set; }
        public decimal CurrentStock { get; set; }
        public string? REF_NO { get; set; }
    }
}
