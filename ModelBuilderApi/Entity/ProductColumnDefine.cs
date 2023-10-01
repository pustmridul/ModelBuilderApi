using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ProductColumnDefine")]
    public class ProductColumnDefine
    {
        public string CompanyCode { get; set; }
        public string Barcode { get; set; }
        public string StyleCode { get; set; }
        public string ColorCode { get; set; }
        public string SizeCode { get; set; }

    }
}
