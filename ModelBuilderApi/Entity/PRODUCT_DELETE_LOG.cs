using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_DELETE_LOG")]
    public class PRODUCT_DELETE_LOG
    {
        public string BARCODE { get; set; }
        public string PARENT_PRODUCT { get; set; }
        public string COMPANY_CODE { get; set; }
        public string DELETED_BY { get; set; }
        public DateTime DELETED_DATE { get; set; }
    }
}
