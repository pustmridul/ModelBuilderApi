using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class PROMOTION_HISTORY
    {
        public string PROMOTION_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public DateTime? INACTIVE_DATE { get; set; }
        public string? INACTIVE_TIME { get; set; }
        public string? INACTIVE_BY { get; set; }
        public DateTime? INACTIVE_ENTRY_DATE { get; set; }
        public string? INACTIVE_STATUS { get; set; }
        public DateTime? EXTEND_DATE { get; set; }
        public string? EXTEND_TIME { get; set; }
        public string? EXTEND_BY { get; set; }
        public DateTime? EXTEND_ENTRY_DATE { get; set; }
        public string? EXTEND_STATUS { get; set; }
        public string? HISTORY_TYPE { get; set; }
    }
}
