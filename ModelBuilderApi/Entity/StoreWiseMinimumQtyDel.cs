using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("StoreWiseMinimumQtyDel")]
    public class StoreWiseMinimumQtyDel
    {
        public string CompanyCode { get; set; }
        public string StoreCategory { get; set; }
        public string StyleCode { get; set; }
        public string Barcode { get; set; }
        public string SaleBarcode { get; set; }
        public string SizeCode { get; set; }
        public string ColorCode { get; set; }
        public decimal MinimumQty { get; set; }
        public string CreateBy { get; set; }
        public DateTime Created { get; set; }
    }
}
