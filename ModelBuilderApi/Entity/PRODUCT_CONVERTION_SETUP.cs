using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_CONVERTION_SETUP")]
    public class PRODUCT_CONVERTION_SETUP
    {
        [Key]
        public string BARCODE { get; set; }
        [Key]
        public string CONVERABLE_BARCODE { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public decimal CONVERTED_QTY { get; set; }
    }
}
