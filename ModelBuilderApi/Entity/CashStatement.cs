using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CashStatement")]
    public class CashStatement
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]
        public string STORE_CODE { get; set; }
        [Key]
        public DateTime DATE { get; set; }
        public decimal? OPENING_BALANCE { get; set; }
        public decimal? CASH_SALE { get; set; }
        public decimal? CARD_SALE { get; set; }
        public decimal? TOTAL_VAT { get; set; }
        public decimal? ADDITIONAL_CASH { get; set; }
        public decimal? TOTAL_RCV { get; set; }
        public decimal? BANK_DEPOSIT { get; set; }
        public decimal? NON_CASH { get; set; }
        public decimal? DAILY_EXPENSE { get; set; }
        public decimal? CASH_WITHDRAW { get; set; }
        public decimal? TOTAL_ADJUSTMENT { get; set; }
        public decimal? CLOSING_BALANCE { get; set; }
        public decimal? TOTAL_DISC_AMT { get; set; }
        public string? POSTED_BY { get; set; }
        public DateTime? POSTED_DATE { get; set; }
        public bool TRANSFER { get; set; }
        public decimal ID { get; set; }
        
}
}
