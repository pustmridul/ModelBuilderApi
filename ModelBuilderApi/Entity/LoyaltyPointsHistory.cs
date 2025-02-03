using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class LoyaltyPointsHistory
    {
        public string CustomerID { get; set; }
        public string OrderID { get; set; }
        public string CustomerPhone { get; set; }
        public decimal? EarndPoint { get; set; }
        public decimal? RedeemPoint { get; set; }
        public string? Reason { get; set; }
    }
}
