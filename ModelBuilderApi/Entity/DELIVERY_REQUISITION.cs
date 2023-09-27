using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("DELIVERY_REQUISITION")]
    public class DELIVERY_REQUISITION
    {
        public string? REQ_NO { get; set; }
        public DateTime? REQ_DATE { get; set; }
        public string? BARCODE { get; set; }
        public string? VARIENT_ID { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public string? PRD_SKU { get; set; }
        public string? PRD_BARCODE { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? QUANTITY { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? ORDER_ID { get; set; }
        public string? ORDER_NUMBER { get; set; }
    }
}
