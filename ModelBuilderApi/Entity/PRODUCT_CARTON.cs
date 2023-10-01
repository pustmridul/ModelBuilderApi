using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_CARTON")]
    public class PRODUCT_CARTON
    {
        [Key]
        public string BARCODE { get; set; }
        public decimal? CARTON_SIZE { get; set; }
        public decimal? CARTON_CPU { get; set; }
        public decimal? CARTON_MRP { get; set; }
        [Key]
        public string CARTON_BARCODE { get; set; }
        [Key]
        public string CARTON_USER_BARCODE { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
    }
}
