using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("VENDOR_REGISTRATION_INFO")]
    public class VENDOR_REGISTRATION_INFO
    {
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? VENDOR_CODE { get; set; }
        public string? INFO_TYPE { get; set; }
        public string? NAME { get; set; }
        public string? ADDRESS { get; set; }
        public string? CITY { get; set; }
        public string? POSTAL_CODE { get; set; }
        public string? COUNTRY { get; set; }
        public string? PHONE { get; set; }
        public string? FAX { get; set; }
        public string? WEB { get; set; }
        public string? EMAIL { get; set; }
        public decimal IS_OWNER { get; set; }
        public decimal IS_PARTNER { get; set; }
        public decimal IS_MEMBER { get; set; }
        public decimal IS_DIRECTOR { get; set; }
    }
}
