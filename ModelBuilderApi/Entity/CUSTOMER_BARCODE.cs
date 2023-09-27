using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CUSTOMER_BARCODE")]
    public class CUSTOMER_BARCODE
    {
        public string? COMPANY_CODE { get; set; }
        public string? CUSTOMER_CODE { get; set; }
        public string? BARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? CUST_BARCODE { get; set; }
        public string? STATUS { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime? ENTRY_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
    }
}
