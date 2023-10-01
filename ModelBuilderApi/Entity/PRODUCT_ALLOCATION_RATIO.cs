using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_ALLOCATION_RATIO")]
    public class PRODUCT_ALLOCATION_RATIO
    {
        [Key]
        public string ALLOCATION_CODE { get; set; }
        [Key]
        public string PARENT_PRODUCT { get; set; }
        public string? SELECTION_VARIANCE_CODE { get; set; }
        public string? ALLOCATION_VARIANCE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
    }
}
