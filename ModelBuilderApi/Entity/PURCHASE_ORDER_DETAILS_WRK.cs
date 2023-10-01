using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PURCHASE_ORDER_DETAILS_WRK")]
    public class PURCHASE_ORDER_DETAILS_WRK
    {
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string? USERNAME { get; set; }
        public DateTime? HOLD_DATE { get; set; }
        public string? VENDOR_CODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string BARCODE { get; set; }
        public decimal PUR_PRICE { get; set; }
        public decimal ORDER_QTY { get; set; }
        public decimal VALUE { get; set; }
        public decimal VAT { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal? COMM_PRCNT { get; set; }
        public decimal? FREE_QTY { get; set; }
        public string? LINE_NOTES { get; set; }
        public string? HOLD_NUMBER { get; set; }
        public string? DO_CompanyCode { get; set; }
        public decimal SAL_PRICE { get; set; }
    }
}
