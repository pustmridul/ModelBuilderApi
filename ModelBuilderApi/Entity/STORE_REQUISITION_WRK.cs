using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_REQUISITION_WRK")]
    public class STORE_REQUISITION_WRK
    {
        public string USERNAME { get; set; }
        public DateTime HOLD_DATE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string VENDOR_CODE { get; set; }
        public string BARCODE { get; set; }
        public string? REQ_BARCODE { get; set; }
        public decimal QTY { get; set; }
        public decimal? BAL_QTY { get; set; }
        public decimal CPU { get; set; }
        public decimal MRP { get; set; }
        public decimal? VAT_PRCENT { get; set; }
    }
}
