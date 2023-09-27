using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CATEGORY")]
    public class CATEGORY
    {
        public string CODE { get; set; }
        public string CATEGORY_NAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? IMAGE_URL { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string DEPARTMENT_CODE { get; set; }
        public string SUB_DEPARTMENT_CODE { get; set; }
        public string? SHORT_CODE { get; set; }
        public bool? EC_SYNC { get; set; }
        public decimal VAT_PERCENT { get; set; }
    }
}
