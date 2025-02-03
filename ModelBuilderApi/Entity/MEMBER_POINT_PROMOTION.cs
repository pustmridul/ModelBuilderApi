using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class MEMBER_POINT_PROMOTION
    {
        public string? PROMOTION_CODE { get; set; }
        public string? PROMOTION_NAME { get; set; }
        public DateTime? VALID_FROM { get; set; }
        public DateTime? VALID_TO { get; set; }
        public string? GROUP_TYPE { get; set; }
        public decimal? MULTIPLIER { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STATUS { get; set; }
    }
}
