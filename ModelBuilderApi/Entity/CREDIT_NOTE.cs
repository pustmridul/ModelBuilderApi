using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CREDIT_NOTE")]
    public class CREDIT_NOTE
    {
        public string? CUSTOMER_ID { get; set; }
        public string? INVOICE_NO { get; set; }
        public DateTime? INVOICE_DATE { get; set; }
        public string? TOKEN_NO { get; set; }
        public decimal VALUE { get; set; }
        public decimal REMAIN_VALUE { get; set; }
        public string? USER_NAME { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string REDEEM_STORE { get; set; }
    }
}
