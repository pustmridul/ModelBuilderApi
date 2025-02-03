using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CreditCollection 
    {
        
        public string COMPANY_CODE { get; set; }
        
        public string STORE_CODE { get; set; }
       
        public string TERMINAL_NO { get; set; }
        public DateTime? DATE { get; set; }
       
        public string VOUCHER_NO { get; set; }
        public string? CUSTOMER_CODE { get; set; }
        public decimal? DEBIT_AMT { get; set; }
        public decimal? CREDIT_AMT { get; set; }
        public decimal? BALANCE_AMT { get; set; }
        public decimal? COLLECTING_AMT { get; set; }
        public string? PAYMENT_CODE { get; set; }
        public string? BANK_NAME { get; set; }
        public string? CHEQUE_NO { get; set; }
        public DateTime? CHEQUE_DATE { get; set; }
        public string? NOTE { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime? ENTRY_DATE { get; set; }
        public string INVOICE_NO { get; set; }
        public decimal? SL_NO { get; set; }
    }
}
