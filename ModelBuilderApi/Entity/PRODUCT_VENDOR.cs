using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_VENDOR")]
    public class PRODUCT_VENDOR
    {
        public string? COMPANY_CODE { get; set; }
        [Key]
        public string BARCODE { get; set; }
        [Key]
        public string VENDOR_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        [Key]
        public string USER_BARCODE { get; set; }
    }
}
