using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class WORKSTATION
    {
        public decimal SERIAL { get; set; }
        
        public string COMPANY_CODE { get; set; }
        
        public string MAC_ADDR { get; set; }
        public string STATUS { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? COUNTER_ID { get; set; }
    }
}
