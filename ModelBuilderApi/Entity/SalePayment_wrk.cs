using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("SalePayment_wrk")]
    public class SalePayment_wrk
    {
        public string? PAYMENT_CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? CARD_NO { get; set; }
        public string? MACHINE_NO { get; set; }
        public decimal? AMOUNT { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string SALESMAN { get; set; }
        public string? TERMINAL_NO { get; set; }
    }
}
