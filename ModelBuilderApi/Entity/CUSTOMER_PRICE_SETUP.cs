using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CUSTOMER_PRICE_SETUP")]
    public class CUSTOMER_PRICE_SETUP
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]
        public string CUSTOMER_CODE { get; set; }
        [Key]
        public string BARCODE { get; set; }
        public decimal? PRICE { get; set; }
        public DateTime? VALID_TO { get; set; }
        public string? STATUS { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime? ENTRY_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string? CustomerType { get; set; }
        public int MAIL_SENDING_BEFORE_VALID_DAYS { get; set; }
    }
}
