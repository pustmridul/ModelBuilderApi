using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PROMOTION_GET")]
    public class PROMOTION_GET
    {

        public string PROMOTION_CODE { get; set; }
        public string PRODUCT_CODE { get; set; }
        public decimal QTY { get; set; }
        public decimal PRICE { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal DISCOUNT_PERCENT { get; set; }
        public string COMPANY_CODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? CATEGORY_CODE { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal DISCOUNT_AMOUNT { get; set; }

    }
}
