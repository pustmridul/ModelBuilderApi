using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class Circular_Disc_Barcode
    {
        public string? PROMOTION_CODE { get; set; }
        public string? PROMOTION_NAME { get; set; }
        public DateTime?  VALID_FROM { get; set; }
        public DateTime? VALID_TO { get; set; }
        public string? Barcode { get; set; }
        public decimal? DISC_PERCENT { get; set; }
        public decimal? DISC_AMOUNT { get; set; }
        public bool? EC_SYNC { get; set; }
        public string INCLUDE_EXCLUDE { get; set; }

    }
}
