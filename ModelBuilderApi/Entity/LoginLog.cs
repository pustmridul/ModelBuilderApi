using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class LoginLog
    {
        public decimal ID { get; set; }
        public string? USER_NAME { get; set; }
        public string? STORE_CODE { get; set; }
        public DateTime? LOGIN_TIME { get; set; }
        public string? STATUS { get; set; }
        public string? REMARKS { get; set; }
        public decimal? EXTERNAL_ID { get; set; }
    }
}
