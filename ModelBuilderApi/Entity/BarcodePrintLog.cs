using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("BarcodePrintLog")]
    public class BarcodePrintLog
    {
        public decimal ID { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? Barcode { get; set; }
        public int? Qty { get; set; }
        public string? Ref { get; set; }
        public string? UserName { get; set; }
        public bool? IsShelfTag { get; set; }
        public string? PrintType { get; set; }
    }
}
