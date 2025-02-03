using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class CourierLog
    {
        public string? COURIER_ID { get; set; }
        public string? TRANSACTION_ID { get; set; }
        public string? ORDER_ID { get; set; }
        public DateTime? SUBMIT_TIME { get; set; }
        public string? ORDER_NUMBER { get; set; }
    }
}
