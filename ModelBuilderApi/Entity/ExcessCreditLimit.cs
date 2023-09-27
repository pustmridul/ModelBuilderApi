using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ExcessCreditLimit")]
    public class ExcessCreditLimit
    {
        [Key]
        public string CODE { get; set; }
        public string CUSTOMER_ID { get; set; }
        public decimal NUMBER_OF_INVOICE { get; set; }
        public decimal CREDIT_VALUE { get; set; }
        public DateTime CREDIT_DATE { get; set; }
        public string COMPANY_CODE { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public int? INVOICE_COUNT { get; set; }
        public decimal? INVOICE_AMOUNT { get; set; }
    }
}
