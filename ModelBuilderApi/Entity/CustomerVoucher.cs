using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CustomerVoucher
    {
       
        public decimal ID { get; set; }
        public string? CUSTOMER_ID { get; set; }
        public string? MOBILE_NO { get; set; }
        public string? VOUCHER_NO { get; set; }
        public decimal? VOUCHER_VALUE { get; set; }
        public bool? SENT { get; set; }
        public DateTime? DATE { get; set; }
        public DateTime? VALID_UPTO { get; set; }
    }
}
