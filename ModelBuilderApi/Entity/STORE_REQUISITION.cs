using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_REQUISITION")]
    public class STORE_REQUISITION
    {
        [Key]
        public string REQUISITION_NO { get; set; }
        public DateTime REQUISITION_DATE { get; set; }
        [Key]
        public string BARCODE { get; set; }
        public decimal QTY { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string REQUISTION_TO { get; set; }
        public string STATUS { get; set; }
        public decimal APPROVED_QTY { get; set; }
        public string? REQ_BARCODE { get; set; }
        public string ENTRY_BY { get; set; }
        public decimal? BAL_QTY { get; set; }
        public string VENDOR_CODE { get; set; }
        public decimal? APPROVED_QTY2 { get; set; }
        public string? APPROVED_BY1 { get; set; }
        public DateTime? APPROVED_DATE1 { get; set; }
        public string? APPROVED_BY2 { get; set; }
        public DateTime? APPROVED_DATE2 { get; set; }
        public string? CANCEL_BY { get; set; }
        public DateTime? CANCEL_DATE { get; set; }
        public string? PO_REF { get; set; }
        public decimal CARTON_SIZE { get; set; }
        public decimal CARTON_QTY { get; set; }
        public string DaysSale1 { get; set; }
        public string DaysSale2 { get; set; }
        public string DaysSale3 { get; set; }
        public decimal CPU { get; set; }
        public decimal MRP { get; set; }
        public string AvgDaySale { get; set; }
        public string DaysRemain { get; set; }
        public bool? IsSyncToERP { get; set; }
        public decimal? VAT_PRCENT { get; set; }
        public decimal? SQTY3MONTH { get; set; }
        public string APPROVAL1_EMAIL_STATUS { get; set; }
        public string APPROVAL2_EMAIL_STATUS { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PO_QTY { get; set; }
        public string? Reason { get; set; }
    }
}
