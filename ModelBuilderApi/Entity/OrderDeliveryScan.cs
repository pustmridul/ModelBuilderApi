using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("OrderDeliveryScan")]
    public class OrderDeliveryScan
    {
        [Key]
        public int Id { get; set; }
        public string ChallanNo { get; set; }
        public DateTime ChallanDate { get; set; }
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string ShippingAddress { get; set; }
        public string CourierServiceName { get; set; }
        public decimal NetAmount { get; set; }
        public string DelDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal? PartialAmount { get; set; }
    }
}
