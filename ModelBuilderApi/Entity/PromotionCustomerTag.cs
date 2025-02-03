using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class PromotionCustomerTag
    {
        
        public string PROMOTION_CODE { get; set; }
       
        public string CUSTOMER_TYPE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public int CUSTOMER_LIMIT { get; set; }
    }
}
