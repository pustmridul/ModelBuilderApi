using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PURCHASE_ORDER_DETAILS")]
    public class PURCHASE_ORDER_DETAILS
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]
        public string STORE_CODE { get; set; }
        [Key]
        public string ORDER_NO { get; set; }
        public DateTime? ORDER_DATE { get; set; }
        public string? VENDOR_CODE { get; set; }
        [Key]
        public string BARCODE { get; set; }
        public decimal LAST_PUR_PRICE { get; set; }
        public decimal CUR_QTY { get; set; }
        public decimal PUR_PRICE { get; set; }
        public decimal ORDER_QTY { get; set; }
        public decimal VALUE { get; set; }
        public decimal VAT { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal RCV_QTY { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal? PRV_ORDER_QTY { get; set; }
        public decimal? COMM_PRCNT { get; set; }
        public decimal? COMM_AMT { get; set; }
        public decimal? FREE_QTY { get; set; }
        public decimal? FREE_AMT { get; set; }
        public decimal? RangeDateSale { get; set; }
        public decimal? LAST_SAL_PRICE { get; set; }
        public decimal? LAST_FREE_QTY { get; set; }
        public decimal? LAST_DISC_PRCNT { get; set; }
        public string? LINE_NOTES { get; set; }
        public decimal? SAL_PRICE { get; set; }
        public string? DONOR_CODE { get; set; }
        public decimal? WH_BAL_QTY { get; set; }
        public decimal? ST_BAL_QTY { get; set; }
        public string? STRS_STOCK_Json { get; set; }
    }
}
