using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class STORE_DELIVERY_DETAILS_DISCP_LOG
    {
        public string CHALLAN_NO { get; set; }
        public DateTime DELIVERY_DATE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string DELIVERY_TO { get; set; }
        public string BARCODE { get; set; }
        public decimal CPU { get; set; }
        public decimal DEL_QTY { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal SAL_PRICE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? IS_GIFT { get; set; }
        public decimal SL { get; set; }
        public bool IS_CARTON { get; set; }
        public string? RCV_NO { get; set; }
        public DateTime? RCV_DATE { get; set; }
    }
}
