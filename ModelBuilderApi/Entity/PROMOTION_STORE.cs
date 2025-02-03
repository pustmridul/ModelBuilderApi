using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class PROMOTION_STORE
    {
        public string PROMOTION_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string TRANSFER { get; set; }
        public decimal TRN_MAX_IDX { get; set; }
        public string INACTIVE_STATUS { get; set; }
        public string EXTEND_STATUS { get; set; }
    }
}
