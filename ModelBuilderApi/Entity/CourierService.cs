using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CourierService")]
    public class CourierService
    {
        public string? COURIER_ID { get; set; }
        public string? NAME { get; set; }
        public string? ADDRESSLINE1 { get; set; }
        public string? ADDRESSLINE2 { get; set; }
        public string? DISTRICT { get; set; }
        public string? EMAIL { get; set; }
        public string? CONTACT_NO { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATION_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public decimal INSIDE_DHAKA { get; set; }
        public decimal AROUND_DHAKA { get; set; }
        public decimal OUTSIDE_DHAKA { get; set; }
        public string? API_URL { get; set; }
        public string? KID { get; set; }
        public string? SUB { get; set; }
        public string? JTI { get; set; }
        public string? AUD { get; set; }
        public string? COURIER_CODE { get; set; }
        public string? ISS { get; set; }
        public string? CLIENT_ID { get; set; }
        public string? SCOPE { get; set; }
        public string? TOKEN_URL { get; set; }
        public string? API_SECRET { get; set; }
        public string? API_KEY { get; set; }
    }
}
