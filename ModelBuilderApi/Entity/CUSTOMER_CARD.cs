using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CustomerCard 
    {
        public string? CUSTOMER_ID { get; set; }
       
        public string CARD_NO { get; set; }
        public DateTime? ACTIVE_DT { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime? ENTRY_DATE { get; set; }

    }
}
