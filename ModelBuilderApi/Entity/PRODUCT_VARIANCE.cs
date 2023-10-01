using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_VARIANCE")]
    public class PRODUCT_VARIANCE
    {
        public string CODE { get; set; }
        [Key]
        public string VARIANCE_NAME { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string INPUT_TYPE { get; set; }
        public bool? SHOW_BARCODE { get; set; }
        public int? SERIAL { get; set; }
        public bool IS_KEY { get; set; }
        public bool SHOW_INV { get; set; }
        public int DISPLAY_SERIAL { get; set; }
        public string? EC_TYPE { get; set; }
        public bool? SHOW_ECOMM { get; set; }
        public bool? IsAllocationAttribute { get; set; }
        public bool IS_SHOW_SEARCH { get; set; }
        public bool? IsPOAttribute { get; set; }
    }
}
