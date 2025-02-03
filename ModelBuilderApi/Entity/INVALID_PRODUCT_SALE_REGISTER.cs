using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class INVALID_PRODUCT_SALE_REGISTER
    {
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? INVOICE_NO { get; set; }
        public DateTime INVOICE_DT { get; set; }
        public string? BARCODE { get; set; }
        public decimal QTY { get; set; }
        public decimal RPU { get; set; }
    }
}
