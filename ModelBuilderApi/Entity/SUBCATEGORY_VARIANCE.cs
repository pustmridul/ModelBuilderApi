using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("SUBCATEGORY_VARIANCE")]
    public class SUBCATEGORY_VARIANCE
    {
        public string? SUB_CATEGORY_CODE { get; set; }
        public string? VARIANCE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
    }
}
