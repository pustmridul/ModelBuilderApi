using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class ProcessedInvoice
    {
        public string? InvoiceNo { get; set; }
        public string? RefNo { get; set; }
        public DateTime? SaleDT { get; set; }
        public string? CounterId { get; set; }
        public string? StoreCode { get; set; }
    }
}
