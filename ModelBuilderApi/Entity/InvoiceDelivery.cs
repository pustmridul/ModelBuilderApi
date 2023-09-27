using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("InvoiceDelivery")]
    public class InvoiceDelivery
    {
        public string? DELIVERY_NO { get; set; }
        public DateTime? DELIVERY_DT { get; set; }
        public string? CUSTOMER_ID { get; set; }
        public string? MOBILE { get; set; }
        public string? DELIVERY_ADDRESS { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? INVOICE_NO { get; set; }
        public DateTime? INVOICE_DT { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime? ENTRY_DT { get; set; }
        public string? STATUS { get; set; }
    }
}
