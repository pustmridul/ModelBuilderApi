using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class TEMP_CIRCULAR_DISCOUNT
    {

        public string? USER_BARCODE { get; set; }
        public decimal? DISC_PERCENT { get; set; }
        public decimal? DISC_AMOUNT { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? USER_NAME { get; set; }
        public string SAL_BARCODE { get; set; }
    }
}
