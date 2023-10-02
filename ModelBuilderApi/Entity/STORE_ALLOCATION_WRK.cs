using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_ALLOCATION_WRK")]
    public class STORE_ALLOCATION_WRK
    {
        public string? ALLOCATION_STORE_CODE { get; set; }
        public string? BARCODE { get; set; }
        public decimal? ALLOCATION_QTY { get; set; }
        public string? USER_NAME { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? ALLOCATION_ATTRIBUTE_CODE { get; set; }
        public string? DISTRIBUTION_ATTRIBUTE_CODE { get; set; }
    }
}
