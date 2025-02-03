using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class PointEarnPolicy
    {
        public string? COMPANY_CODE { get; set; }
        public decimal? SPEND_AMT { get; set; }
        public string? GROUP_TYPE { get; set; }
        public decimal? EARN_POINT { get; set; }
        public decimal? POINT_VAL { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public decimal MIN_REDEEM_POINT { get; set; }
    }
}
