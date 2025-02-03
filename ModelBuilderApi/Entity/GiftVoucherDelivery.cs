using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class GiftVoucherDelivery
    {
        public string? ChallanNo { get; set; }
        public DateTime? ChallanDate { get; set; }
        public string? STORE_CODE { get; set; }
        public string? DELIVERY_TO { get; set; }
        public long? TotalNoOfCard { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? COMPANY_CODE { get; set; }
        public decimal? TotalAmount { get; set; }
        public string Status { get; set; }
        public string CUSTOMER_ID { get; set; }

    }
}
