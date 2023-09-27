using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("DISCOUNT_NONBRAND")]
    public class DISCOUNT_NONBRAND
    {
        public string COMPANY_CODE { get; set; }
        public byte? IS_NON_BRAND { get; set; }
        public byte? IS_BIRTHDAY { get; set; }
        public int? DAY_BEFORE { get; set; }
        public int? DAY_AFTER { get; set; }
        public decimal DISCOUNT { get; set; }
        public string? CUSTOMER_TYPE { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
    }
}
