using System.ComponentModel.DataAnnotations;

namespace ModelBuilderApi.New_Entity
{
    public class BookingSummary
    {

        [Key]
        public string BOOKING_NO { get; set; }
        public DateTime? BOOKING_DT { get; set; }
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
        public decimal? DUE_AMT { get; set; }
        public DateTime? BOOKING_EXPIRE_DT { get; set; }
        public string? TERMINAL_NO { get; set; }
        public string? TIME { get; set; }
        public string? INVOICE_REF { get; set; }
        public decimal? RTN_VAT { get; set; }
        public decimal? ADJ_AMT { get; set; }
        public string STATUS { get; set; }
        public string? Flag { get; set; }
        public string? MOBILE_NO { get; set; }
        public decimal SD_AMT { get; set; }
        public decimal RTN_SD_AMT { get; set; }
        public string? Booking_Type { get; set; }
        public string? Booking_Ref { get; set; }
    }
}
