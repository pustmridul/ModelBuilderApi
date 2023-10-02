using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_DML")]
    public class STORE_DML
    {
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string REF_NO { get; set; }
        public DateTime DML_DATE { get; set; }
        public string BARCODE { get; set; }
        public decimal DML_QTY { get; set; }
        public string? REASON { get; set; }
        public string? STORE_REF_NO { get; set; }
        public string SAL_BARCODE { get; set; }
        public decimal SAL_PRICE { get; set; }
        public decimal CPU { get; set; }
        public string? IS_GIFT { get; set; }
        public string? USER_BARCODE { get; set; }
        public string TRANSFER { get; set; }
        public decimal? SL { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string? COMMENTS { get; set; }
        public string? CUSTOMER_REF { get; set; }
        public string? INVOICE_REF { get; set; }
        public string? Act_Transfer { get; set; }
        public string? STATUS { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string? REMARKS { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public string? RCV_NO { get; set; }
        public DateTime? RCV_DATE { get; set; }
    }
}
