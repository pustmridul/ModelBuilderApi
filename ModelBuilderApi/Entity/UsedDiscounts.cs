using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("UsedDiscounts")]
    public class UsedDiscounts
    {
        public long id { get; set; }
        public string Order_id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? CouponCode { get; set; }
    }
}
