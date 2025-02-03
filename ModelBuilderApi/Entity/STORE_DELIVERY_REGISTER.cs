using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class STORE_DELIVERY_REGISTER
    {

        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? DELIVERY_TO { get; set; }
        public string? BARCODE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public decimal CPU { get; set; }
        public decimal DEL_QTY { get; set; }
        public string? CHALLAN_NO { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal SAL_PRICE { get; set; }
    }
}
