using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PURCHASE_RCV_DETAILS_WRK")]
    public class PURCHASE_RCV_DETAILS_WRK
    {
        public string? BARCODE { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public decimal? ORDER_QTY { get; set; }
        public string? PUR_UOM_NAME { get; set; }
        public decimal? REM_QTY { get; set; }
        public decimal? PUR_PRICE { get; set; }
        public string? USER_BARCODE1 { get; set; }
        public DateTime? MANUFACTURE_DATE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public decimal? RCV_QTY { get; set; }
        public decimal? FREE_QTY { get; set; }
        public decimal? SAL_PRICE { get; set; }
        public string SAL_BARCODE { get; set; }
        public bool? selected { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? VENDOR_CODE { get; set; }
        public string? ORDER_NO { get; set; }
        public bool? is_gift { get; set; }
        public decimal? IS_EXPIRY_ITEM { get; set; }
        public decimal? IS_MANUFACTURE_DT_REQUIRED { get; set; }
        public string? BARCODE_INCLUDE { get; set; }
        public decimal? RCV_AMOUNT { get; set; }
        public decimal? RCV_VAT { get; set; }
        public string? REF_NO { get; set; }
        public bool IS_CARTON { get; set; }
        public string DELIVERY_TO { get; set; }
        public decimal? RCV_PRICE { get; set; }
        public decimal? CPU { get; set; }
        public bool? is_bonus { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public string? DISC_NOTE { get; set; }
        public int? CHLN_SL { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public bool IS_BATCH_REQUIRED { get; set; }
        public string? BATCH_NO { get; set; }
        public DateTime ENTRY_DATE { get; set; }
    }
}
