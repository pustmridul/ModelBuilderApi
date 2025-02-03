using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class Temp_BillPayment
    {
        public decimal ID { get; set; }
        public string BillSlNo { get; set; }
        public DateTime? vDate { get; set; }
        public decimal? BillAmt { get; set; }
        public string? SupRef { get; set; }
        public string? CostCenterID { get; set; }
        public string? UserId { get; set; }
        public string? Company { get; set; }
        public string? ActCodeSup { get; set; }
    }
}
