using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class SSUMMARY
    {
       
        public string INVOICE_NO { get; set; }
       
        public DateTime? INVOICE_DT { get; set; }
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
      
        public string STORE_CODE { get; set; }
       
        public string COMPANY_CODE { get; set; }
        public string? CUS_GROUP { get; set; }
        public string? CUSTOMER_CODE { get; set; }
        public string? CUSTOMER_NAME { get; set; }
        public string? CUSTOMER_ADDRESS { get; set; }
        public decimal? CASH_AMT { get; set; }
        public decimal? CARD_AMT { get; set; }
        public decimal? OTHER_AMT { get; set; }
        public decimal? PAID_AMT { get; set; }
        public decimal? CHANGE_AMT { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? TIME { get; set; }
        public string? INVOICE_REF { get; set; }
        public decimal? RTN_VAT { get; set; }
        public decimal? ADJ_AMT { get; set; }
        public decimal? ERN_POINT { get; set; }
        public decimal? RDM_POINT { get; set; }
        public decimal? RDM_VAL { get; set; }
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
        public string? DELIVERY_PERSON { get; set; }
        public decimal ADV_AMT { get; set; }
        public string BOOKING_NO { get; set; }
        public string INVOICE_NOTE { get; set; }
        public decimal CreditBalance { get; set; }
        public decimal LastReceiveAmount { get; set; }
        public DateTime? LastRcvDate { get; set; }
        public decimal InvoiceCreditAmount { get; set; }
        public string? ORDER_ID { get; set; }
        public decimal DELIVERY_CHARGE { get; set; }
        public string? EXCHANGE_TOKEN { get; set; }
        public decimal? BAL_POINT { get; set; }
        public string CUST_BIN { get; set; }
        public decimal SDC_VAT_AMT { get; set; }
        public decimal SDC_SD_AMT { get; set; }
        public string SDC_INVOICE_NO { get; set; }
        public string SDC_QR_CODE { get; set; }
        public string SDC_SL_NO { get; set; }
        public decimal? BANK_COMM_AMT { get; set; }
        public string? VAT_EXTERNAL_NO { get; set; }
        public string? EarnPointPromotionCode { get; set; }
        public string? ThirdPartCreditCustomerSale { get; set; }
        public string? ThridPartyCreditCustomerRequest { get; set; }
        public string? ThirdPartyCreditCustomerResponse { get; set; }
        public decimal? ADV_ADJ_AMT { get; set; }
        public string? DoctorName { get; set; }
        public string? HospitalName { get; set; }
        public string AC_RDM_Posting { get; set; }
        public string? AC_Transfer { get; set; }
    }
}
