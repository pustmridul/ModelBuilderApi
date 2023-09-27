using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CustomerType")]
    public class CustomerType
    {
        public string? Group_Type { get; set; }
        [Key]
        public string Group_Name { get; set; }
        public decimal? Discount_Prcnt { get; set; }
        public string? Company_Code { get; set; }
        public string? Entery_by { get; set; }
        public DateTime Entry_date { get; set; }
        public string? Updated_by { get; set; }
        public DateTime? Updated_date { get; set; }
        public string PROMO_PRICE { get; set; }
        public bool? SCAN_CARD_ON_SAL { get; set; }
        public bool GiftVoucherDeliveryToCustomer { get; set; }

    }
}
