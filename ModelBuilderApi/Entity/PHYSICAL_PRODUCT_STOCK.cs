using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class PHYSICAL_PRODUCT_STOCK
    {
        public string BARCODE { get; set; }
        public string SAL_BARCODE { get; set; }
        public decimal SAL_CPU { get; set; }
        public decimal SAL_PRICE { get; set; }
        public decimal BAL_QTY { get; set; }
        public string STORE_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public decimal SAL_BAL_QTY { get; set; }
        public string? USER_BARCODE { get; set; }
    }
}
