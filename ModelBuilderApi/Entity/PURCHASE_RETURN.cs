using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class PURCHASE_RETURN
    {
      
        public string CHALLAN_NO { get; set; }
        public DateTime RTN_DT { get; set; }
        public string? REF_NO { get; set; }
       
        public string COMPANY_CODE { get; set; }
        
        public string STORE_CODE { get; set; }
        public decimal TOTAL_QTY { get; set; }
        public decimal TOTAL_VALUE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string VENDOR_CODE { get; set; }
        public string TRANSFER { get; set; }
        public string? STATUS { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string? REMARKS { get; set; }
    }
}
