namespace ModelBuilderApi.QueryResultModels
{
    public class GetProductStockListQueryResult
    {
        //For VW_ProductStock
        public string? COMPANY_CODE { get; set; }
        public string? Company_Name { get; set; }
        public string? STORE_CODE { get; set; }
        public string? BARCODE { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public string SAL_BARCODE { get; set; }
        public decimal SAL_CPU { get; set; }
        public decimal SAL_PRICE { get; set; }
        public decimal QTY { get; set; }
        public decimal? STORE_RCV_QTY { get; set; }
        public decimal? TRANSFER_QTY { get; set; }
        public decimal? DML_QTY { get; set; }
        public decimal? SAL_QTY { get; set; }
        public decimal? SAL_RTN_QTY { get; set; }
        public decimal AdjQty { get; set; }
        public decimal? SAL_BAL_QTY { get; set; }
        public string? CATEGORY_CODE { get; set; }
        public string Category_name { get; set; }
        public string? SUB_CATEGORY_CODE { get; set; }
        public string sub_category_name { get; set; }
        public string? BRAND_CODE { get; set; }
        public string Brand_Name { get; set; }
        public string? SAL_UOM_NAME { get; set; }
        public bool? IS_PRICE_INCLD_VAT { get; set; }
        public decimal SAL_VAT_PERCENT { get; set; }
        public bool? IS_MANAGE_STOCK { get; set; }
        public bool? IS_NOT_FOR_SALE { get; set; }
        public bool? IS_SCALE { get; set; }
        public bool? IS_ACTIVE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? USER_BARCODE1 { get; set; }
        public string? USER_BARCODE2 { get; set; }
        public string? USER_BARCODE3 { get; set; }
        public decimal SKU { get; set; }
        public string? ITEM_TYPE { get; set; }
        public string IS_GIFT { get; set; }
        public decimal SL { get; set; }
        public bool? IS_NEGATIVE { get; set; }
        public decimal? SD_PERCENT { get; set; }
        public bool? ZERO_PRICE_SAL { get; set; }
        public string? STYLE_CODE { get; set; }
        public decimal? BAL_QTY { get; set; }
        public decimal? COST_VALUE { get; set; }
        public decimal? CPU { get; set; }
        public decimal? FREE_QTY { get; set; }
        public decimal? OPENING_STOCK { get; set; }
        public decimal? PUR_RTN_QTY { get; set; }
        public decimal? RCV_QTY { get; set; }
        public string? STORE_NAME { get; set; }

        // For VW_PRODUCT


        public decimal LAST_PUR_PRICE { get; set; }
        public decimal MRP { get; set; }
        public bool IS_BARGAIN_SALE { get; set; }
        public decimal? CONV_IN { get; set; }
        public decimal? CONV_OUT { get; set; }
        public decimal? IS_EXPIRY_ITEM { get; set; }
        public bool IS_PUR_PRICE_INCLD_VAT { get; set; }
        public string? PUR_UOM_NAME { get; set; }
        public decimal CARTON_SIZE { get; set; }
        public decimal PUR_VAT_PERCENT { get; set; }
        public string SDC_SD_CODE { get; set; }
        public string SDC_VAT_CODE { get; set; }
        public string? VENDOR_CODE01 { get; set; }
        public string? VENDOR_NAME01 { get; set; }
        public string? VENDOR_CODE02 { get; set; }
        public string? VENDOR_NAME02 { get; set; }
        public string? VENDOR_CODE03 { get; set; }
        public string? VENDOR_NAME03 { get; set; }
        public string? VENDOR_CODE04 { get; set; }
        public string? VENDOR_NAME04 { get; set; }
        public string? VENDOR_CODE05 { get; set; }
        public string? VENDOR_NAME05 { get; set; }
        public string? VENDOR_CODE06 { get; set; }
        public string? VENDOR_NAME06 { get; set; }
        public string? VENDOR_CODE07 { get; set; }
        public string? VENDOR_NAME07 { get; set; }
        public string? VENDOR_CODE08 { get; set; }
        public string? VENDOR_NAME08 { get; set; }
        public string? VENDOR_CODE09 { get; set; }
        public string? VENDOR_NAME09 { get; set; }
        public string? A01 { get; set; }
        public string? A02 { get; set; }
        public string? A03 { get; set; }
        public string? A04 { get; set; }
        public string? A05 { get; set; }
        public string? A06 { get; set; }
        public string? A07 { get; set; }
        public string? A08 { get; set; }
        public string? A09 { get; set; }
        public string? A10 { get; set; }
        public string? A11 { get; set; }
        public string? A12 { get; set; }
        public string? A13 { get; set; }
        public string? A14 { get; set; }
        public string? A15 { get; set; }
        public string? A16 { get; set; }
        public string? A17 { get; set; }
        public string? A18 { get; set; }
        public string? A19 { get; set; }
        public string? A20 { get; set; }
        public string? UCODE01 { get; set; }
        public string? UCODE02 { get; set; }
        public string? UCODE03 { get; set; }
        public string? UCODE04 { get; set; }
        public string? UCODE05 { get; set; }
        public string? UCODE06 { get; set; }
        public string? UCODE07 { get; set; }
        public string? UCODE08 { get; set; }
        public string? UCODE09 { get; set; }
        public string? UCODE10 { get; set; }
        public string? UCODE11 { get; set; }
        public string? UCODE12 { get; set; }
        public string? UCODE13 { get; set; }
        public string? UCODE14 { get; set; }
        public string? UCODE15 { get; set; }
        public string? VENDOR_CODE { get; set; }
        public string? VENDOR_NAME { get; set; }





        //No Coloumn Found  In BengalMeat Database
        public bool? IS_MANUFACTURE_DT_REQUIRED { get; set; }
        public string? BARCODE_INCLUDE { get; set; }
        public string? DEPARTMENT_CODE { get; set; }
        public string? SUB_DEPARTMENT_CODE { get; set; }
        public string? SUB_SUBCATEGORY_CODE { get; set; }
        public decimal? pack_size { get; set; }
        public string? MANUFACTURER_CODE { get; set; }
        public string? MANUFACTURER_NAME { get; set; }
        public bool? IS_BATCH_REQUIRED { get; set; }
        public string? BSTI { get; set; }
        public string? ARTICLE_NO { get; set; }

    }
}


