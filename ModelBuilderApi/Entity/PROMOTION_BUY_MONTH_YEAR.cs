using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class PROMOTION_BUY_MONTH_YEAR
    {               
        public string? PROMOTION_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? VARIANCE_VAL { get; set; }
        public string? START_MONTH { get; set; }
        public string? START_YEAR { get; set; }
        public string? END_MONTH { get; set; }
        public string? END_YEAR { get; set; }
        public decimal? DISC_PERCENT { get; set; }
    }
}
