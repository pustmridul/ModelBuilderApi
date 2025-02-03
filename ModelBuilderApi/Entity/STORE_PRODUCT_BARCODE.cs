using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class STORE_PRODUCT_BARCODE
    {
        
        public string COMPANY_CODE { get; set; }
       
        public string STORE_CODE { get; set; }
        
        public string PRODUCT_CODE { get; set; }
        
        public string USER_BARCODE { get; set; }
        
        public string STORE_BARCODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
    }
}
