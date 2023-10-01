using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("OtpHistory")]
    public class OtpHistory
    {
        public decimal ID { get; set; }
        public string? MOBILE_NO { get; set; }
        public string? OTP { get; set; }
        public DateTime? CTIME_STAMP { get; set; }
        public int? LIFT_TIME { get; set; }
        public int? STATUS { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? REF { get; set; }

    }
}
