using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("DocPrintLog")]
    public class DocPrintLog
    {
        public decimal ID { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? DocType { get; set; }
        public string? DocNumber { get; set; }
        public string? UserName { get; set; }
    }
}
