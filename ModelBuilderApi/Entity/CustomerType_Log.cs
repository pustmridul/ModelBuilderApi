using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CustomerType_Log")]
    public class CustomerType_Log
    {
        public string? Group_Type { get; set; }
        public string? Group_Name { get; set; }
        public decimal? Discount_Prcnt { get; set; }
        public string? Company_Code { get; set; }
        public string? Entery_by { get; set; }
        public DateTime Entry_date { get; set; }
        public string? Updated_by { get; set; }
        public DateTime? Updated_date { get; set; }
        public string PROMO_PRICE { get; set; }
        public bool GiftVoucherDeliveryToCustomer { get; set; }
    }
}
