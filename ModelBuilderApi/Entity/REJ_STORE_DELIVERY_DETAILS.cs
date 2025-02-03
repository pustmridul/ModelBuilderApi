using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class REJ_STORE_DELIVERY_DETAILS
    {

        public string CHALLAN_NO { get; set; }
        public DateTime DELIVERY_DATE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string DELIVERY_TO { get; set; }
        public string BARCODE { get; set; }
        public decimal CPU { get; set; }
        public decimal DEL_QTY { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public decimal RCV_QTY { get; set; }
        public DateTime? RECEIVE_DATE { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal SAL_PRICE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? IS_GIFT { get; set; }
        public decimal SL { get; set; }
        public bool IS_CARTON { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public decimal DISC_PRCNT { get; set; }
        public decimal VAT_PERCENT { get; set; }
        public string? REASON { get; set; }
        public string? Act_Transfer { get; set; }
        public string? Act_Transfer_WH { get; set; }
        public string? Act_Transfer_Store { get; set; }
        public decimal? SAL_VAT_PERCENT { get; set; }
        public string STATUS { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
