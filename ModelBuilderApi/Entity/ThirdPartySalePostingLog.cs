using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ThirdPartySalePostingLog")]
    public class ThirdPartySalePostingLog
    {
        [Key]
        public decimal AutoId { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public DateTime Posted_DT { get; set; }
        public string? ThirdPartCreditCustomerSale { get; set; }
        public string? ThridPartyCreditCustomerRequest { get; set; }
        public string? ThirdPartyCreditCustomerResponse { get; set; }
    }
}
