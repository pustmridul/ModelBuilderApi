using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class ReportLog
    {
        
        public int serial { get; set; }
        public string? userName { get; set; }
        public string? reportName { get; set; }
        public string? typeOfReport { get; set; }
        public string? reportParam { get; set; }
        public string? reportType { get; set; }
        public string? reportFileName { get; set; }
        public DateTime? inTime { get; set; }
        public DateTime? outTime { get; set; }
    }
}
