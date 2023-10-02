using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ReOrderSetup")]
    public class ReOrderSetup
    {
        [Key]
        public string Barcode { get; set; }
        [Key]
        public string StoreCode { get; set; }
        public int? ReOrderQty { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
    }
}
