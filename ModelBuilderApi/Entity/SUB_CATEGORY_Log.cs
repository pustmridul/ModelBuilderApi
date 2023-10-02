using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("SUB_CATEGORY_Log")]
    public class SUB_CATEGORY_Log
    {
        public string CODE { get; set; }
        public string SUB_CATEGORY_NAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string? IMAGE_URL { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? DEPARTMENT_CODE { get; set; }
        public string? SUB_DEPARTMENT_CODE { get; set; }
        public string? SHORT_CODE { get; set; }
    }
}
