using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("StoreNotification")]
    public class StoreNotification
    {

        public decimal ID { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? MESSAGE_HEADER { get; set; }
        public string? MESSAGE_BODY { get; set; }
        public string EMAIL_SENT { get; set; }
        public string SMS_SENT { get; set; }
        public string NOTIFICATION_SENT { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime? ENTRY_DATE { get; set; }
        public string? NOTIFICATION_REQ { get; set; }
        public string? NOTIFICATION_RES { get; set; }
        public string? SMS_REQ { get; set; }
        public string? SMS_RES { get; set; }
        public string? EMAIL_REQ { get; set; }
        public string? EMAIL_RES { get; set; }
    }
}
