using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("Temp_BillEntry")]
    public class Temp_BillEntry
    {
        public int ID { get; set; }
        public string BillSlNo { get; set; }
        public string? SupId { get; set; }
        public string? SupName { get; set; }
        public DateTime? vDate { get; set; }
        public string? ActCode { get; set; }
        public string? ActName { get; set; }
        public string? RefNo { get; set; }
        public string? Narration { get; set; }
        public decimal? BillAmt { get; set; }
        public string? CostCenter { get; set; }
        public string? UserId { get; set; }
        public string? Company { get; set; }
    }
}
