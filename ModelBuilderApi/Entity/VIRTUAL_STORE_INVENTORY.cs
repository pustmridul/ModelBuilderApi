using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class VIRTUAL_STORE_INVENTORY
    {
        public string? SESSION_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? BARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal? SCAN_QTY { get; set; }
        public string? USER_NAME { get; set; }
        public DateTime? UPLOADED_DATE { get; set; }
        public bool? IS_ADJ { get; set; }

    }
}
