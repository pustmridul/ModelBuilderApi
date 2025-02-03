using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class Notification
    {
        public decimal ID { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? CREATOR { get; set; }
        public string? RECEIVER_ROLE { get; set; }
        public string? RECEIVER { get; set; }
        public string? NOTE { get; set; }
        public string STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }

    }
}
