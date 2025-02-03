using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class Production
    {
        public string? CHALLAN_NO { get; set; }
        public DateTime? DATE { get; set; }
        public string? BARCODE { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal? CPU { get; set; }
        public decimal? SAL_PRICE { get; set; }
        public decimal? QTY { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public DateTime? MANUFACTURE_DATE { get; set; }
        public string USER_NAME { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string TERMINAL_ID { get; set; }
        public string STATUS { get; set; }
    }
}
