using System.ComponentModel.DataAnnotations;

namespace ModelBuilderApi.New_Entity
{
    public class PRODUCT_STOCK
    {
        public string? BARCODE { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public decimal CPU { get; set; }
        public decimal QTY { get; set; }
        public decimal RCV_QTY { get; set; }
        public decimal FREE_QTY { get; set; }
        public decimal PUR_RTN_QTY { get; set; }
        public decimal BAL_QTY { get; set; }
        public string? COMPANY_CODE { get; set; }
        [Key]
        public string STORE_CODE { get; set; }
        public decimal OPENING_STOCK { get; set; }
        public decimal SAL_QTY { get; set; }
        public decimal SAL_RTN_QTY { get; set; }
        public decimal TRANSFER_QTY { get; set; }
        public decimal SAL_BAL_QTY { get; set; }
        public decimal SAL_CPU { get; set; }
        public decimal STORE_RCV_QTY { get; set; }
        public decimal DML_QTY { get; set; }
        [Key]
        public string SAL_BARCODE { get; set; }
      
        public decimal SAL_PRICE { get; set; }
        public decimal SL { get; set; }
        public decimal AdjQty { get; set; }
        public decimal? WriteOn { get; set; }
        public decimal? WriteOff { get; set; }
        public decimal CONV_IN { get; set; }
        public decimal CONV_OUT { get; set; }
        public bool? IsSync { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public decimal? ORD_QTY { get; set; }
        public decimal? RTN_ORD_QTY { get; set; }
        public bool? IsSend { get; set; }
        public decimal? Discrepancy { get; set; }
        public string? BATCH_NO { get; set; }
        public DateTime? LAST_PUR_DATE { get; set; }
        public string? CHALLAN_NO { get; set; }
        public DateTime? CHALLAN_DATE { get; set; }
        public bool? EC_SYNC { get; set; }
    }
}
