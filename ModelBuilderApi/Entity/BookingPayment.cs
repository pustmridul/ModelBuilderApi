using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class BookingPayment
    {
        public string BOOKING_NO { get; set; }
        public DateTime? BOOKING_DT { get; set; }
        public string? PAYMENT_CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? CARD_NO { get; set; }
        public string? MACHINE_NO { get; set; }
        public decimal? AMOUNT { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? SALESMAN { get; set; }
        public string? TERMINAL_NO { get; set; }
        public decimal? ID { get; set; }
        public string? Flag { get; set; }
        public bool IS_RECONCILIED { get; set; }
        public string AC_Transfer { get; set; }
    }
}
