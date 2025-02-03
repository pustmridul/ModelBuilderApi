using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class PRODUCT_CARTON
    {
       
        public string BARCODE { get; set; }
        public decimal? CARTON_SIZE { get; set; }
        public decimal? CARTON_CPU { get; set; }
        public decimal? CARTON_MRP { get; set; }
       
        public string CARTON_BARCODE { get; set; }
        
        public string CARTON_USER_BARCODE { get; set; }
        
        public string COMPANY_CODE { get; set; }
    }
}
