using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class P_PACKAGE_SALE_REGISTER
    {
        public string? PACKAGE_CODE { get; set; }
        public string? INVOICE_NO { get; set; }
        public DateTime? INVOICE_DT { get; set; }
        public string? BARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal? CPU { get; set; }
        public decimal? MRP { get; set; }
        public decimal? PKG_MRP { get; set; }
        public decimal? SQTY { get; set; }
        public decimal? SUB_TOTAL { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public string? DISC_TYPE { get; set; }
        public decimal? VAT_PRCNT { get; set; }
        public decimal? VAT_AMT { get; set; }
        public decimal? SPECIAL_DISCOUNT { get; set; }
        public decimal? RQTY { get; set; }
        public decimal? RTN_SUB_AMT { get; set; }
        public decimal? RTN_VAT { get; set; }
        public decimal? RTN_DISC { get; set; }
        public decimal? NET_AMT { get; set; }
        public string? SALESMAN { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? TERMINAL_ID { get; set; }
        public decimal? RTN_AMT { get; set; }
        public decimal? ACT_CPU { get; set; }
        public bool? IS_PRICE_INCLD_VAT { get; set; }
        public string? SERIAL_NO { get; set; }
        public string? IS_GIFT { get; set; }
        public string? RTN_INV_REF { get; set; }
        public decimal? SL { get; set; }
        public string? TRANSFER { get; set; }
    }
}
