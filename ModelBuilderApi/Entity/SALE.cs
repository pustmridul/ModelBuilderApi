using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("SALE")]
    public class SALE
    {
        public string INVOICE_NO { get; set; }
        public DateTime INVOICE_DT { get; set; }
        public string BARCODE { get; set; }
        public string USER_BARCODE { get; set; }
        public string SAL_BARCODE { get; set; }
        public decimal CPU { get; set; }
        public decimal MRP { get; set; }
        public decimal SQTY { get; set; }
        public decimal SUB_TOTAL { get; set; }
        public decimal DISC_PRCNT { get; set; }
        public decimal DISC_AMT { get; set; }
        public string? DISC_TYPE { get; set; }
        public decimal VAT_PRCNT { get; set; }
        public decimal VAT_AMT { get; set; }
        public decimal SPECIAL_DISCOUNT { get; set; }
        public decimal RQTY { get; set; }
        public decimal RTN_SUB_AMT { get; set; }
        public decimal RTN_VAT { get; set; }
        public decimal RTN_DISC { get; set; }
        public decimal RTN_AMT { get; set; }
        public decimal NET_AMT { get; set; }
        public string? SALESMAN { get; set; }
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string? TERMINAL_ID { get; set; }
        public decimal? ACT_CPU { get; set; }
        public string? TIME { get; set; }
        public bool? IS_PRICE_INCLD_VAT { get; set; }
        public string? SERIAL_NO { get; set; }
        public string? IS_GIFT { get; set; }
        public string? RTN_INV_REF { get; set; }
        public decimal SL { get; set; }
        public string? Transfer { get; set; }
        public string? CogsTransfer { get; set; }
        public bool IS_CARTON { get; set; }
        public decimal AMRP { get; set; }
        public decimal CARTON_SIZE { get; set; }
        public string? SAL_EXECUTIVE { get; set; }
        public bool? IS_CLAIM { get; set; }
        public string? CLAIM_CODE { get; set; }
        public string? RTN_INV_STORE { get; set; }
        public decimal SD_PERCENT { get; set; }
        public decimal SD_AMT { get; set; }
        public decimal RTN_SD_AMT { get; set; }
        public string DISC_NOTE { get; set; }
        public decimal RTN_SPECIAL_DISC { get; set; }
        public string? ORDER_ID { get; set; }
        public string RETURN_REASON { get; set; }
        public string? AC_SACTransfer { get; set; }
        public string SDC_VAT_CODE { get; set; }
        public decimal SDC_VAT_AMT { get; set; }
        public string SDC_SD_CODE { get; set; }
        public decimal SDC_SD_AMT { get; set; }
        public string SDC_INVOICE_NO { get; set; }
        public string? VAT_EXTERNAL_NO { get; set; }
        public string? RCV_NO { get; set; }
        public DateTime? RCV_DATE { get; set; }
        public string? BATCH { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
    }
}
