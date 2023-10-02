using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("SUB_SUBCATEGORY_VARIANCE_VALUE")]
    public class SUB_SUBCATEGORY_VARIANCE_VALUE
    {

        public string? SUB_SUBCATEGORY_CODE { get; set; }
        public string? VARIANCE_CODE { get; set; }
        public string? ATTRIBUTE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
    }
}
