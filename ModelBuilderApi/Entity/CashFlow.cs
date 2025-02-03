using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CashFlow
    {
        public decimal ID { get; set; }
        public string REF_NO { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? TYPE { get; set; }
        public DateTime? DATE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? NARRATION { get; set; }
        public decimal? AMOUNT { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime? ENTRY_DATE { get; set; }
        public string STATUS { get; set; }
        public string TRANSFER { get; set; }
    }
}
