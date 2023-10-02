using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("StoreDelivery_Wrk")]
    public class StoreDelivery_Wrk
    {
        public string? SAL_BARCODE { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? BARCODE { get; set; }
        public decimal? SAL_PRICE { get; set; }
        public decimal? DEL_QTY { get; set; }
        public string? SAL_UOM_NAME { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public decimal? CPU { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public string? IS_GIFT { get; set; }
        public decimal? SL { get; set; }
        public bool? IS_CARTON { get; set; }
        public string? USER_NAME { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public decimal? ALC_QTY { get; set; }
        public string? DELIVERY_TO { get; set; }
        public decimal SERIAL { get; set; }
        public string? UUID { get; set; }
        public string? RCV_NO { get; set; }
        public DateTime? RCV_DATE { get; set; }
        public decimal CurrentStock { get; set; }
        public string? VENDOR_NAME { get; set; }
        public string STYLE_CODE { get; set; }
    }
}
