using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class ProductionIng
    {
        public string? CHALLAN_NO { get; set; }
        public DateTime? DATE { get; set; }
        public string? ING_BARCODE { get; set; }
        public string? ING_SAL_BARCODE { get; set; }
        public decimal? ING_PRD_CPU { get; set; }
        public decimal? ING_PRD_SAL_PRICE { get; set; }
        public decimal? CONVERTED_QTY { get; set; }
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
