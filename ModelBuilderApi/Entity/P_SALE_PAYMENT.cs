using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class P_SALE_PAYMENT
    {
        public string? INVOICE_NO { get; set; }
        public DateTime? INVOICE_DATE { get; set; }
        public string? PAYMENT_CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? CARD_NO { get; set; }
        public string? MACHINE_NO { get; set; }
        public decimal? AMOUNT { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? SALESMAN { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? Transfer { get; set; }
        public decimal? SERVICE_CHARGE { get; set; }
    }
}
