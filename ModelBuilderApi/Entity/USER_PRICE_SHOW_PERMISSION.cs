using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class USER_PRICE_SHOW_PERMISSION
    {
        public string COMPANY_CODE { get; set; }
        public string USER_NAME { get; set; }
        public string DEPARTMENT_CODE { get; set; }
        public string SUB_DEPARTMENT_CODE { get; set; }
        public string? CATEGORY_CODE { get; set; }
        public string? SUB_CATEGORY_CODE { get; set; }
        public string? SUB_SUBCATEGORY_CODE { get; set; }
        public string? VENDOR_CODE { get; set; }
        public string? BRAND_CODE { get; set; }
        public bool SHOW_COST { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
