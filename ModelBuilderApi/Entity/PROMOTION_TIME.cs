using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PROMOTION_TIME")]
    public class PROMOTION_TIME
    {
        public string PROMOTION_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public decimal MRP { get; set; }
        public decimal? WSP { get; set; }
        public decimal PRICE1 { get; set; }
        public decimal PRICE2 { get; set; }
        public decimal PRICE3 { get; set; }
        public decimal PRICE4 { get; set; }
        public string? SAL_BARCODE { get; set; }
    }
}
