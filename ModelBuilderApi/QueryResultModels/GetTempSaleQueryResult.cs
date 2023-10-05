using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.QueryResultModels
{
    public class GetTempSaleQueryResult
    {
        public string? BARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal SKU { get; set; }
        public string? SAL_BARCODE { get; set; }
        public string? DISPLAY_NAME { get; set; }
        public decimal? MRP { get; set; }
        public decimal? AMRP { get; set; }
        public decimal? SQTY { get; set; }
        public decimal? VAT_PRCNT { get; set; }
        public decimal? VAT_AMT { get; set; }
        public decimal? SUB_TOTAL { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public string? DISC_TYPE { get; set; }
        public string? DISC_NAME { get; set; }
        public bool? IS_PRICE_INCLD_VAT { get; set; }
        public decimal? NET_AMT { get; set; }
        public string? SERIAL_NO { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? HOLD_TOKEN { get; set; }
        public string? SALESMAN { get; set; }
        public decimal? CPU { get; set; }
        public string IS_GIFT { get; set; }
        public DateTime? HOLD_TIME { get; set; }
        public decimal? RQTY { get; set; }
        public decimal? RTN_SUB_AMT { get; set; }
        public decimal? RTN_VAT { get; set; }
        public decimal? RTN_DISC { get; set; }
        public decimal? RTN_AMT { get; set; }
        public string? RTN_INV_REF { get; set; }
        public decimal SL { get; set; }
        public decimal LINE { get; set; }
        public string? PKG_REF { get; set; }
        public decimal? DISC_PRICE { get; set; }
        public bool? IS_CARTON { get; set; }
        public string? SAL_EXECUTIVE { get; set; }
        public bool? IS_CLAIM { get; set; }
        public string? CLAIM_CODE { get; set; }
        public string? RTN_INV_STORE { get; set; }
        public string ORDER_INVOICE { get; set; }
        public bool IS_DISC_EXEMPTION { get; set; }
        public bool ZERO_PRICE_SAL { get; set; }
        public decimal? SD_PERCENT { get; set; }
        public decimal? SD_AMT { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string BRAND_CODE { get; set; }
        /////Not Coloumn Found  In BengalMeat Database      

         public string? Disc_note { get; set; }
         public string? RTN_SPECIAL_DISC { get; set; }
         public string? STYLE_CODE { get; set; }
         public DateTime? UPDATED_DT { get; set; }
         public string? SDC_VAT_CODE { get; set; }
         public decimal? SDC_VAT_AMT { get; set; }
         public string? SDC_SD_CODE { get; set; }
         public decimal? SDC_SD_AMT { get; set; }
         public string? Customer_code { get; set; }
         public string? Customer_name { get; set; }
         public string? Mobile_NO { get; set; }
         public bool? IS_SCALE { get; set; }
         public string? HOLD_TOKEN2 { get; set; }
         public string? HOLD_TIME2 { get; set; }
         public decimal? RTN_SD_AMT { get; set; }

    }
}

