using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ReportSection")]
    public class ReportSection
    {
        public string? SectionName { get; set; }
        public decimal? Code { get; set; }
    }
}
