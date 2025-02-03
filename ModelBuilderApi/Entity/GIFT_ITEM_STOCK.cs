using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class GIFT_ITEM_STOCK
    {
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? BARCODE { get; set; }
        public string? PRODUCT_NAME { get; set; }
        public decimal RCV_QTY { get; set; }
        public decimal TRANSFER_QTY { get; set; }
        public decimal RTN_QTY { get; set; }
        public decimal SAL_QTY { get; set; }
        public decimal SAL_RTN_QTY { get; set; }
        public decimal BAL_QTY { get; set; }
        public decimal DML_QTY { get; set; }
    }
}
