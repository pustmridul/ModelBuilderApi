using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ProductConversionWrk")]
    public class ProductConversionWrk
    {
        public string? BARCODE { get; set; }
        public string? SAL_BARCODE { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public decimal? CPU { get; set; }
        public decimal? SAL_PRICE { get; set; }
        public decimal? QTY { get; set; }
        public string? LINK_BARCODE { get; set; }
        public string? LINK_DISPLAY_NAME { get; set; }
        public decimal? CONVERTED_QTY { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public DateTime? MANUFACTURE_DATE { get; set; }
        public string USER_NAME { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
    }
}
