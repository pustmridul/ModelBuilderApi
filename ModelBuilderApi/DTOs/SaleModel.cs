using System;

namespace ModelBuilderApi.DTOs
{
    public class SaleModel
    {

    }

    public class SaleVM
    {
        public string BARCODE { get; set; }
        public string USER_BARCODE { get; set; }
        public string SKU { get; set; }
        public string SAL_BARCODE { get; set; }
        public string DISPLAY_NAME { get; set; }
        public decimal MRP { get; set; }
        public decimal SQTY { get; set; }
        public decimal VAT_PRCNT { get; set; }
        public decimal VAT_AMT { get; set; }
        public decimal DISC_PRCNT { get; set; }
        public decimal DISC_AMT { get; set; }
        public string DISC_TYPE { get; set; }
        public bool IS_PRICE_INCLD_VAT { get; set; }
        public string NET_AMT { get; set; }
        public string SERIAL_NO { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string TERMINAL_NO { get; set; }
        public string HOLD_TOKEN { get; set; }
        public string SALESMAN { get; set; }
        public decimal CPU { get; set; }
        public decimal SUB_TOTAL { get; set; }
        public decimal RQTY { get; set; }
        public decimal RTN_SUB_AMT { get; set; }
        public decimal RTN_VAT { get; set; }
        public decimal RTN_DISC { get; set; }
        public decimal RTN_AMT { get; set; }
        public string RTN_INV_REF { get; set; }
        public string DISC_NAME { get; set; }
        public decimal SD_PERCENT { get; set; }
        public bool IS_DISC_EXEMPTION { get; set; }
        public bool IS_CARTON { get; set; }
        public decimal SL { get; set; }
        public string SAL_EXECUTIVE { get; set; }
        public bool ZERO_PRICE_SAL { get; set; }
        public bool IS_CLAIM { get; set; }
        public string CLAIM_CODE { get; set; }
        public string RTN_INV_STORE { get; set; }
        public decimal SD_AMT { get; set; }
        public string PKG_REF { get; set; }
        public decimal DISC_PRICE { get; set; }
        public DateTime Hold_TIME { get; set; }


        // Not found in DB 
        public string SPECIAL_DISC { get; set; }
        public string STYLE_CODE { get; set; }
        public string UPDATED_DT { get; set; }
        public string IS_NEGATIVE { get; set; }
        public string IS_MANAGE_STOCK { get; set; }
        public string CARTON_SIZE { get; set; }
        public string Booking_Type { get; set; }
        public string Booking_Ref { get; set; }
        public string BRAND_NAME { get; set; }
        public string BATCH { get; set; }
        public string category_name { get; set; }
        public string SUB_SUBCATEGORY_NAME { get; set; }
        public string Attribute1 { get; set; }
        public string EXPIRE_DATE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string MOBILE_NO { get; set; }
        public string ARMP { get; set; }
    }
}
