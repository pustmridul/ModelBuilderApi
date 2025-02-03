using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class SALE_ORDER
    {
        public string? ORDER_NO { get; set; }
        public DateTime? ORDER_DT { get; set; }
        public decimal? COST_PRICE { get; set; }
        public decimal? ITEM_PRICE { get; set; }
        public decimal? VAT_AMT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public decimal? SPECIAL_DISCOUNT { get; set; }
        public decimal? RTN_AMT { get; set; }
        public decimal? RTN_DISC_AMT { get; set; }
        public decimal? RTN_SPECIAL_DISCOUNT { get; set; }
        public decimal? NET_AMT { get; set; }
        public string? SALESMAN { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? CUS_GROUP { get; set; }
        public string? CUSTOMER_CODE { get; set; }
        public string? CUSTOMER_NAME { get; set; }
        public string? CUSTOMER_ADDRESS { get; set; }
        public decimal? CASH_AMT { get; set; }
        public decimal? CARD_AMT { get; set; }
        public decimal? OTHER_AMT { get; set; }
        public decimal? ERN_POINT { get; set; }
        public decimal? RDM_POINT { get; set; }
        public decimal? RDM_VAL { get; set; }
        public decimal? PAID_AMT { get; set; }
        public decimal? CHANGE_AMT { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? TIME { get; set; }
        public string? INVOICE_REF { get; set; }
        public decimal? RTN_VAT { get; set; }
        public decimal? ADJ_AMT { get; set; }
        public string? CHALLAN_NO { get; set; }
        public decimal? SERVICE_CHARGE { get; set; }
        public bool? CRM_SYNC { get; set; }
        public bool? CUS_SYNC { get; set; }
        public decimal? AMRP { get; set; }
        public bool? GONDOLA_SYNC { get; set; }
        public string? MOBILE_NO { get; set; }
        public string? VEHICLE_NO { get; set; }
        public decimal SD_AMT { get; set; }
        public decimal RTN_SD_AMT { get; set; }
        public string ORDER_STATUS { get; set; }
        public string? DELIVERY_PERSON { get; set; }
        public string? INVOICE_NO { get; set; }
        public string? CANCEL_BY { get; set; }
        public DateTime? CANCEL_DATE { get; set; }
        public string? PRD_SKU { get; set; }
        public string? PRD_BARCODE { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
    }
}
