using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("UpdateRemove_Log")]
    public class UpdateRemove_Log
    {

        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? CUSTOMER_CODE { get; set; }
        public string? SALESMAN { get; set; }
        public string? BARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal? MRP { get; set; }
        public decimal? SCANED_QTY { get; set; }
        public decimal? UPDATED_QTY { get; set; }
        public string? SERIAL { get; set; }
        public DateTime? INVOICE_DT { get; set; }
        public string? DISC_TYPE { get; set; }
        public string? REF { get; set; }
        public string? TYPE { get; set; }
        public string? AUTHENTICATE_ID { get; set; }
        public string? HOLD_TOKEN { get; set; }
        public string? HOLD_TIME { get; set; }
        public decimal AutoId { get; set; }
    }
}
