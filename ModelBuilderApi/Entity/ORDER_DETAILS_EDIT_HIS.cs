using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class ORDER_DETAILS_EDIT_HIS
    {
        public int Id { get; set; }
        public string? BARCODE { get; set; }
        public string? VARIENT_ID { get; set; }
        public string? TITLE { get; set; }
        public string? VARIENT_TITLE { get; set; }
        public long? QUANTITY { get; set; }
        public decimal? CPU { get; set; }
        public decimal? PRICE { get; set; }
        public string? ORDER_ID { get; set; }
        public string? TEX_LINE_TITLE { get; set; }
        public decimal? TEX_LINE_PRICE { get; set; }
        public decimal? TEX_LINE_RATE { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public decimal? VALUE { get; set; }
        public decimal? NET_VALUE { get; set; }
        public string? PRD_SKU { get; set; }
        public string? PRD_BARCODE { get; set; }
        public decimal? DEL_QTY { get; set; }
        public decimal? DEL_RTN_QTY { get; set; }
        public string ShopifySync { get; set; }
        public DateTime? EDIT_DATE { get; set; }

    }
}
