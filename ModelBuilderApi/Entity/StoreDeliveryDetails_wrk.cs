using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("StoreDeliveryDetails_wrk")]
    public class StoreDeliveryDetails_wrk
    {
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? DELIVERY_TO { get; set; }
        public string? BARCODE { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public decimal? CPU { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal? SAL_PRICE { get; set; }
        public decimal? DEL_QTY { get; set; }
        public string? ENTRY_BY { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? BRAND_NAME { get; set; }
        public string? CATEGORY_NAME { get; set; }
        public string? SUB_CATEGORY_NAME { get; set; }
        public string? UOM { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public string USER_BARCODE { get; set; }
        public string? IS_GIFT { get; set; }
        public decimal SL { get; set; }
        public string? VENDOR_NAME { get; set; }
    }
}
