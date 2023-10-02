using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_PRODUCT_BARCODE")]
    public class STORE_PRODUCT_BARCODE
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]
        public string STORE_CODE { get; set; }
        [Key]
        public string PRODUCT_CODE { get; set; }
        [Key]
        public string USER_BARCODE { get; set; }
        [Key]
        public string STORE_BARCODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
    }
}
