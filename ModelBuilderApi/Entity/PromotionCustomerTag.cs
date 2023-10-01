using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PromotionCustomerTag")]
    public class PromotionCustomerTag
    {
        [Key]
        public string PROMOTION_CODE { get; set; }
        [Key]
        public string CUSTOMER_TYPE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public int CUSTOMER_LIMIT { get; set; }
    }
}
