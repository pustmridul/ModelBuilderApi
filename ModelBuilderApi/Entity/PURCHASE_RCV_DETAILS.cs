using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PURCHASE_RCV_DETAILS")]
    public class PURCHASE_RCV_DETAILS
    {
        public string MEMO_NO { get; set; }
        public DateTime PURCHASE_DATE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string BARCODE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public decimal PUR_PRICE { get; set; }
        public decimal PUR_QTY { get; set; }
        public decimal FREE_QTY { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal VAT { get; set; }
        public decimal VAT_PRCNT { get; set; }
        public decimal IS_PRICE_INCLD_VAT { get; set; }
        public decimal ACT_PUR_PRICE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string SAL_BARCODE { get; set; }
        public decimal SAL_PRICE { get; set; }
        public string? USER_BARCODE { get; set; }
        public DateTime? MANUFACTURE_DATE { get; set; }
        public decimal AL { get; set; }
        public decimal IS_GIFT { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public decimal SL { get; set; }
        public bool? IS_CARTON { get; set; }
        public string? DELIVERY_TO { get; set; }
        public decimal BARCODE_FACTOR { get; set; }
        public decimal? RCV_PRICE { get; set; }
        public decimal? CPU { get; set; }
        public int? CHLN_SL { get; set; }
        public string STATUS { get; set; }
        public decimal? CARTON_QTY { get; set; }
        public decimal CARTON_SIZE { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public string? DISC_NOTE { get; set; }
        public bool IS_BATCH_REQUIRED { get; set; }
        public string? BATCH_NO { get; set; }
        public string? DONOR_CODE { get; set; }
        public DateTime ENTRY_DATE { get; set; }
    }
}
