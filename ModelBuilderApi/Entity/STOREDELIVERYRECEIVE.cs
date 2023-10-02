using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STOREDELIVERYRECEIVE")]
    public class STOREDELIVERYRECEIVE
    {
        public string CHALLAN_NO { get; set; }
        public DateTime? DELIVERY_DATE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string DELIVERY_TO { get; set; }
        public string BARCODE { get; set; }
        public decimal? CPU { get; set; }
        public string AL { get; set; }
        public decimal? DEL_QTY { get; set; }
        public decimal? RCV_QTY { get; set; }
        public DateTime? RECEIVE_DATE { get; set; }
        public string? RECEIVE_BY { get; set; }
        public string SAL_BARCODE { get; set; }
        public decimal SAL_PRICE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string Status { get; set; }
        public string? IS_GIFT { get; set; }
        public decimal SL { get; set; }
        public bool? IS_CARTON { get; set; }
        public string? Act_Transfer_Store { get; set; }
        public string? Act_Transfer_CS { get; set; }
        public string? RCV_NO { get; set; }
        public DateTime? RCV_DATE { get; set; }
        public string? AC_DelReceived { get; set; }
    }
}
