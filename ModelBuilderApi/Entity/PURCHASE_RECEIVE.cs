using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class PURCHASE_RECEIVE
    {
       
        public string MEMO_NO { get; set; }
        public DateTime PURCHASE_DATE { get; set; }
        public string VENDOR_CODE { get; set; }
        public string? REF_NO { get; set; }
        public decimal TOTAL_VALUE { get; set; }
        public decimal TOTAL_VAT { get; set; }
        public decimal DISCOUNT_AMT { get; set; }
        public decimal ADDITIONAL_COST { get; set; }
        public decimal NET_AMOUNT { get; set; }
       
        public string COMPANY_CODE { get; set; }
      
        public string STORE_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? ORDER_NO { get; set; }
        public decimal AL { get; set; }
        public string? STATUS { get; set; }
        public string TRANSFER { get; set; }
        public string? DELIVERY_TO { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string? REMARKS { get; set; }
        public string? Act_Transfer { get; set; }
        public string? DONOR_CODE { get; set; }
        public bool? MANAGE_DONORWISE_STOCK { get; set; }
        public string IsPAY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string? NOTE { get; set; }
        public decimal? ADJUST_AMOUNT { get; set; }
    }
}
