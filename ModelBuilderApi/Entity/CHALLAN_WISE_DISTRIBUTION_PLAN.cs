using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class CHALLAN_WISE_DISTRIBUTION_PLAN
    {
        public string CHALLAN_NO { get; set; }
        public DateTime CHALLAN_DATE { get; set; }
        public string? BARCODE { get; set; }
        public string? SAL_BARCODE { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal MRP { get; set; }
        public decimal CDC_QTY { get; set; }
        public decimal VALUE { get; set; }
        public decimal RETAIL { get; set; }
        public decimal FRANCHISE { get; set; }
        public decimal COUNTER { get; set; }
        public decimal MT { get; set; }
        public decimal DISTRIBUTION { get; set; }
        public decimal ONLINE { get; set; }
        public decimal TOTAL { get; set; }
        public string COMPANY_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string? STYLE_CODE { get; set; }
    }
}
