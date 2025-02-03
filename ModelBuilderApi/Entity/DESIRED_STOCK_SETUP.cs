using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class DESIRED_STOCK_SETUP
    {
        
        public string STORE_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        
        public string BARCODE { get; set; }
        public decimal DESIRED_QTY { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }

    }
}
