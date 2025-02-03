using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class USER_PRICE_PERMISSION
    {
        public string USER_NAME { get; set; }
        public string BARCODE { get; set; }
        public bool HIDE_COST { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
    }
}
