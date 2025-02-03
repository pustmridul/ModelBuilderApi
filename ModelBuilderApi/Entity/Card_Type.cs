using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CardType
    {
        public string? Card_Type { get; set; }
        public string Card_Name { get; set; }
        public decimal? VOUCHER_AMOUNT { get; set; }
        public string COMPANY_CODE { get; set; }
        public string? Entry_by { get; set; }
        public DateTime Entry_date { get; set; }
        public string? Updated_by { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? VALID_MONTH { get; set; }
        public bool DeliveryToStore { get; set; }
        public bool? DeliveryToCustomer { get; set; }
        public bool MANUAL_EXPIRY { get; set; }
    }
}
