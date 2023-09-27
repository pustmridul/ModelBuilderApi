using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("DONOR")]
    public class DONOR
    {
        public int ID { get; set; }
        public string? DONOR_CODE { get; set; }
        public string? DONOR_NAME { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? ADDRESS { get; set; }
        public string? COUNTRY { get; set; }
        public string? CONTACT_NO { get; set; }
        public string? CONTACT_PERSON { get; set; }
        public string? EMAIL { get; set; }
        public string? WEBSITE { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public bool INACTIVE { get; set; }
        public string? EXTERNAL_CODE { get; set; }
    }
}
