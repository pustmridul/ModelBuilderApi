using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ORDER_DETAILS_WRK")]
    public class ORDER_DETAILS_WRK
    {
        [Key]
        public int Id { get; set; }
        public string? BARCODE { get; set; }
        public string? VARIENT_ID { get; set; }
        public string? TITLE { get; set; }
        public string? VARIENT_TITLE { get; set; }
        public long? QUANTITY { get; set; }
        public decimal? PRICE { get; set; }
        public string? ORDER_ID { get; set; }
        public string? TEX_LINE_TITLE { get; set; }
        public decimal? TEX_LINE_PRICE { get; set; }
        public decimal? TEX_LINE_RATE { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public string? PRD_SKU { get; set; }
        public string? PRD_BARCODE { get; set; }
        public string? SESSION_ID { get; set; }
        public string? EMPLOYEE_ID { get; set; }
        public string? STORE_CODE { get; set; }
    }
}
