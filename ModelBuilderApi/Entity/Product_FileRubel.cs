﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("Product_FileRubel")]
    public class Product_FileRubel
    {
        public string COMPANY_CODE { get; set; }
        public string Company_Name { get; set; }
        public string BARCODE { get; set; }
        public string SBARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string NAME { get; set; }
        public string? CATEGORY_CODE { get; set; }
        public string category_name { get; set; }
        public string? SUB_CATEGORY_CODE { get; set; }
        public string sub_category_name { get; set; }
        public string? BRAND_CODE { get; set; }
        public string Brand_Name { get; set; }
        public string? COUNTRY_OF_ORGIN { get; set; }
        public decimal? PUR_UOM { get; set; }
        public string? PUR_UOM_NAME { get; set; }
        public decimal? SALE_UOM { get; set; }
        public string? SAL_UOM_NAME { get; set; }
        public decimal CONVERTION_RATE { get; set; }
        public decimal IS_SCALE { get; set; }
        public decimal PUR_VAT_PERCENT { get; set; }
        public decimal SAL_VAT_PERCENT { get; set; }
        public decimal IS_PRICE_INCLD_VAT { get; set; }
        public bool IS_PUR_PRICE_INCLD_VAT { get; set; }
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
        public string? PARENT_PRODUCT { get; set; }
        public string ITEM_TYPE { get; set; }
        public string? SUB_PRODUCT_DESCRIPTION { get; set; }
        public string? USER_BARCODE1 { get; set; }
        public string? USER_BARCODE2 { get; set; }
        public string? USER_BARCODE3 { get; set; }
        public decimal SKU { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? PACK_SIZE { get; set; }
        public string? VENDOR_CODE { get; set; }
        public decimal IS_MANUFACTURE_DT_REQUIRED { get; set; }
        public string? BARCODE_INCLUDE { get; set; }
        public bool IS_NEGATIVE { get; set; }
        public bool HAS_CARTON { get; set; }
        public decimal CARTON_SIZE { get; set; }
        public decimal? CARTON_CPU { get; set; }
        public decimal? CARTON_MRP { get; set; }
        public string? CARTON_BARCODE { get; set; }
        public string? CARTON_USER_BARCODE { get; set; }
        public string? REGIONAL_NAME { get; set; }
        public bool IS_TRACK_RCV_SERIAL { get; set; }
        public bool IS_CONVERTABLE { get; set; }
        public decimal SD_PERCENT { get; set; }
        public bool ZERO_PRICE_SAL { get; set; }
        public string? VENDOR_NAME { get; set; }
        public string? ATTRIBUTE_NAME { get; set; }
        public bool? IS_BARCODE_PRICE_SAL { get; set; }
        public bool? Is_Sync { get; set; }
        public decimal? WHOLESALE_QTY { get; set; }
        public string? PRD_INV_NAME { get; set; }
        public bool IS_DISC_EXEMPTION { get; set; }
        public bool IS_BARGAIN_SALE { get; set; }
        public bool HAS_WARRANTY { get; set; }
        public decimal WARRANTY_PERIOD { get; set; }
        public string? FREE_TEXT1 { get; set; }
        public string? FREE_TEXT2 { get; set; }
        public string? FREE_TEXT3 { get; set; }
        public string? FREE_TEXT4 { get; set; }
        public string? FREE_TEXT5 { get; set; }
        public string DEPARTMENT_CODE { get; set; }
        public string? DEPARTMENT_NAME { get; set; }
        public string SUB_DEPARTMENT_CODE { get; set; }
        public string? SUB_DEPARTMENT_NAME { get; set; }
        public string? PRD_SKU { get; set; }
        public string? PRD_BARCODE { get; set; }
        public int? COLL_NO { get; set; }
        public bool? EC_SYNC { get; set; }
        public string? SUB_SUBCATEGORY_CODE { get; set; }
        public string? SUB_SUBCATEGORY_NAME { get; set; }
        public string? STYLE_CODE { get; set; }
        public bool IS_EC_PRODUCT { get; set; }
        public string SDC_VAT_CODE { get; set; }
        public string SDC_SD_CODE { get; set; }
        public string MANUFACTURER_CODE { get; set; }
        public string? MANUFACTURER_NAME { get; set; }
        public bool IS_BATCH_REQUIRED { get; set; }
        public bool? BSTI { get; set; }
        public string? ARTICLE_NO { get; set; }
        public int? SHELF_LIFE_DAYS { get; set; }
        public string? WH_SHELF_LOCATION { get; set; }
        public bool? IS_MP_EXEMPTION { get; set; }
        public decimal PUR_CONVERTION_RATE { get; set; }
        public string? HSCODE { get; set; }
        public bool? EC_SYNC_STOCK { get; set; }
        public bool IS_CPU_Average { get; set; }
    }
}