using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class CUSTOMER_CREDIT_LEDGER
    {
        
        public string COMPANY_CODE { get; set; }
       
        public string STORE_CODE { get; set; }
       
        public string CUSTOMER_CODE { get; set; }
        public decimal DEBIT_AMT { get; set; }
        public decimal CREDIT_AMT { get; set; }
        public decimal BALANCE_AMT { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
    }
}
