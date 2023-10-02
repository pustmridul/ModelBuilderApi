using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_TRANSFER_PERMISSION")]
    public class STORE_TRANSFER_PERMISSION
    {
        public string STORE_CODE { get; set; }
        public string DELIVERY_TO { get; set; }
        public string COMPANY_CODE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string STATUS { get; set; }
    }
}
