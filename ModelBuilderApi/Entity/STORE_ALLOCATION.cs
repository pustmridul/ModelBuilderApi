using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class STORE_ALLOCATION
    {
      
        public string ALLOCATION_CODE { get; set; }
        public DateTime ALLOCATION_DATE { get; set; }
   
        public string? ALLOCATION_ATTRIBUTE_CODE { get; set; }
        public string? DISTRIBUTION_ATTRIBUTE_CODE { get; set; }
       
        public string ALLOCATION_STORE_CODE { get; set; }
        
        public string BARCODE { get; set; }
        public decimal ALLOCATION_QTY { get; set; }
        public string USER_NAME { get; set; }
       
        public string STORE_CODE { get; set; }
      
        public string COMPANY_CODE { get; set; }
        public string STATUS { get; set; }

    }
}
