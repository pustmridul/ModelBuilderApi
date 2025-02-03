using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class ReportHead
    {
        public decimal SLNO { get; set; }
        public string? ChartHead { get; set; }
        public string? Section { get; set; }
        public string? SubSection { get; set; }
        public string? ActCode { get; set; }
        public string? Formula { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
