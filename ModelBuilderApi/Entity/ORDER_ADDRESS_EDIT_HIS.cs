using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class ORDER_ADDRESS_EDIT_HIS
    {
        public int Id { get; set; }
        public string? ORDER_ID { get; set; }
        public string? ADDRESS_TYPE { get; set; }
        public string? FIRST_NAME { get; set; }
        public string? ADDRESS1 { get; set; }
        public string? PHONE { get; set; }
        public string? CITY { get; set; }
        public string? ZIP { get; set; }
        public string? PROVINCE { get; set; }
        public string? COUNTRY { get; set; }
        public string? LAST_NAME { get; set; }
        public string? ADDRESS2 { get; set; }
        public string? COMPANY { get; set; }
        public string? LALITUDE { get; set; }
        public string? LONGITUDE { get; set; }
        public string? NAME { get; set; }
        public string? COUNTRY_CODE { get; set; }
        public string? PROVINCE_CODE { get; set; }
        public DateTime? EDIT_DATE { get; set; }

    }
}
