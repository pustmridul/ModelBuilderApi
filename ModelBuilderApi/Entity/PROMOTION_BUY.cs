using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class PROMOTION_BUY
    {
        public string PROMOTION_CODE { get; set; }
        public string? CATEGORY_CODE { get; set; }
        public string? SUB_CATEGORY_CODE { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? VENDOR_CODE { get; set; }
        public string? ITEM_NAME { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal QTY { get; set; }
        public decimal PRICE { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal DISC_PERCENT { get; set; }
        public decimal DISC_PRICE { get; set; }
        public string COMPANY_CODE { get; set; }
        public decimal DISC_AMOUNT { get; set; }
        public decimal DISC_VAT { get; set; }
        public decimal IS_PRICE_INCLD_VAT { get; set; }
        public decimal? SL { get; set; }
        public decimal SD_PERCENT { get; set; }
        public decimal SD_AMT { get; set; }
        public bool IS_CARTON { get; set; }
        public string REF_CODE { get; set; }
        public decimal IDX { get; set; }
        public decimal? WSP_DISC_PERCENT { get; set; }
        public decimal? WSP_DISC_AMOUNT { get; set; }
        public decimal? PRICE1_DISC_PERCENT { get; set; }
        public decimal? PRICE1_DISC_AMOUNT { get; set; }
        public decimal? PRICE2_DISC_PERCENT { get; set; }
        public decimal? PRICE2_DISC_AMOUNT { get; set; }
        public decimal? PRICE3_DISC_PERCENT { get; set; }
        public decimal? PRICE3_DISC_AMOUNT { get; set; }
        public decimal? PRICE4_DISC_PERCENT { get; set; }
        public decimal? PRICE4_DISC_AMOUNT { get; set; }
        public decimal? VENDOR_CONTRIBUTION_PERCENT { get; set; }
        public decimal? VENDOR_CONTRIBUTION_AMOUNT { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal REDUCTION_QTY { get; set; }
        public decimal PROMOTION_PERIOD_LIMIT { get; set; }
        public string? TO_PRODUCT_CODE { get; set; }
        public string INCLUDE_EXCLUDE { get; set; }
    }
}
