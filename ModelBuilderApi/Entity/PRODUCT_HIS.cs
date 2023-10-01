using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_HIS")]
    public class PRODUCT_HIS
    {
        public decimal SKU { get; set; }
        public string COMPANY_CODE { get; set; }
        public string BARCODE { get; set; }
        public string SBARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string NAME { get; set; }
        public string? CATEGORY_CODE { get; set; }
        public string? SUB_CATEGORY_CODE { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? COUNTRY_OF_ORGIN { get; set; }
        public string? PUR_UOM { get; set; }
        public string? SALE_UOM { get; set; }
        public decimal CONVERTION_RATE { get; set; }
        public decimal IS_SCALE { get; set; }
        public decimal PUR_VAT_PERCENT { get; set; }
        public bool IS_PUR_PRICE_INCLD_VAT { get; set; }
        public decimal SAL_VAT_PERCENT { get; set; }
        public decimal IS_PRICE_INCLD_VAT { get; set; }
        public decimal MRP { get; set; }
        public decimal WSP { get; set; }
        public decimal PRICE1 { get; set; }
        public decimal PRICE2 { get; set; }
        public decimal PRICE3 { get; set; }
        public decimal PRICE4 { get; set; }
        public decimal MRP_VAT { get; set; }
        public decimal WSP_VAT { get; set; }
        public decimal PRICE1_VAT { get; set; }
        public decimal PRICE2_VAT { get; set; }
        public decimal PRICE3_VAT { get; set; }
        public decimal PRICE4_VAT { get; set; }
        public decimal MRP_INCLD_VAT { get; set; }
        public decimal WSP_INCLD_VAT { get; set; }
        public decimal PRICE1_INCLD_VAT { get; set; }
        public decimal PRICE2_INCLD_VAT { get; set; }
        public decimal PRICE3_INCLD_VAT { get; set; }
        public decimal PRICE4_INCLD_VAT { get; set; }
        public decimal MRP_EXCLD_VAT { get; set; }
        public decimal WSP_EXCLD_VAT { get; set; }
        public decimal PRICE1_EXCLD_VAT { get; set; }
        public decimal PRICE2_EXCLD_VAT { get; set; }
        public decimal PRICE3_EXCLD_VAT { get; set; }
        public decimal PRICE4_EXCLD_VAT { get; set; }
        public decimal IS_MANAGE_STOCK { get; set; }
        public decimal MIN_STK_QTY { get; set; }
        public decimal REORDER_QTY { get; set; }
        public decimal OPENING_STK { get; set; }
        public decimal LAST_PUR_PRICE { get; set; }
        public decimal IS_EXPIRY_ITEM { get; set; }
        public decimal IS_NOT_FOR_SALE { get; set; }
        public decimal IS_SHOP_REQ { get; set; }
        public decimal HAS_BOM { get; set; }
        public decimal IS_ACTIVE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? IMAGE_URL { get; set; }
        public string? PARENT_PRODUCT_HIS { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string ITEM_TYPE { get; set; }
        public string? SUB_PRODUCT_HIS_DESCRIPTION { get; set; }
        public string? USER_BARCODE1 { get; set; }
        public string? USER_BARCODE2 { get; set; }
        public string? USER_BARCODE3 { get; set; }
        public string? PACK_SIZE { get; set; }
        public string? VENDOR_CODE { get; set; }
        public decimal IS_MANUFACTURE_DT_REQUIRED { get; set; }
        public string? BARCODE_INCLUDE { get; set; }
        public bool IS_NEGATIVE { get; set; }
        public bool HAS_CARTON { get; set; }
        public decimal? CARTON_SIZE { get; set; }
        public decimal? CARTON_CPU { get; set; }
        public decimal? CARTON_MRP { get; set; }
        public string? CARTON_BARCODE { get; set; }
        public string? CARTON_USER_BARCODE { get; set; }
        public string? REGIONAL_NAME { get; set; }
        public bool IS_TRACK_RCV_SERIAL { get; set; }
        public bool IS_CONVERTABLE { get; set; }
        public decimal SD_PERCENT { get; set; }
        public bool ZERO_PRICE_SAL { get; set; }
        public DateTime UPDATED_ON { get; set; }
        public string? DEPARTMENT_CODE { get; set; }
        public string? SUB_DEPARTMENT_CODE { get; set; }
        public string? SUB_SUBCATEGORY_CODE { get; set; }
        public string? STYLE_CODE { get; set; }
        public string? MANUFACTURER_CODE { get; set; }
    }
}
