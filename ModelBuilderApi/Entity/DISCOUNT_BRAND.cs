using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class DISCOUNT_BRAND
    {
        public string COMPANY_CODE { get; set; }
        public string? BRAND_CODE { get; set; }
        public decimal DISCOUNT { get; set; }
        public string? CUSTOMER_TYPE { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
    }
}
