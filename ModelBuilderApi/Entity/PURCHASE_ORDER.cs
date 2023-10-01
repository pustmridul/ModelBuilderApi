using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PURCHASE_ORDER")]
    public class PURCHASE_ORDER
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]
        public string STORE_CODE { get; set; }
        [Key]
        public string ORDER_NO { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public string VENDOR_CODE { get; set; }
        public string? REF { get; set; }
        public DateTime DELIVERY_DATE { get; set; }
        public decimal TOTAL_VAL { get; set; }
        public decimal TOTAL_VAT { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string? DELIVERY_TO { get; set; }
        public string? REMARKS { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string TRANSFER { get; set; }
        public decimal? TOTAL_COMM_AMT { get; set; }
        public decimal? TOTAL_FREE_AMT { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public int? DIVIDER { get; set; }
        public string? DONOR_CODE { get; set; }
        public string? DO_CompanyCode { get; set; }
    }
}
