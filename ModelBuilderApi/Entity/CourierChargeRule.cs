using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CourierChargeRule")]
    public class CourierChargeRule
    {
        [Key]
        public string CourierId { get; set; }
        public string? NAME { get; set; }
        public decimal FromWeight { get; set; }
        public decimal ToWeight { get; set; }
        public decimal RegularCharge { get; set; }
        public decimal? ExpressCharge { get; set; }
        public decimal? OverseasCharge { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
