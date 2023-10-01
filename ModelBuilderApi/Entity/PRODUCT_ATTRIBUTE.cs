using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_ATTRIBUTE")]
    public class PRODUCT_ATTRIBUTE
    {
        public string BARCODE { get; set; }
        public string VARIANCE_CODE { get; set; }
        public string? ATTRIBUTE_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CRATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? PARENT_PRODUCT { get; set; }

    }
}
