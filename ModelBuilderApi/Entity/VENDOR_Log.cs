using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("VENDOR_Log")]
    public class VENDOR_Log
    {

        public string VENDOR_CODE { get; set; }
        public string VENDOR_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string POSTAL_CODE { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public string CONTACT_NO { get; set; }
        public string? EMAIL { get; set; }
        public string? WEBSITE { get; set; }
        public DateTime DOE { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? ACTHEAD { get; set; }
        public string STATUS { get; set; }
        public string STORE_CODE { get; set; }
        public decimal IS_MANAGE_STOCK { get; set; }
        public string O_OR_P { get; set; }
        public string? PAYMENT_METHOD { get; set; }
        public decimal PAYMENT_MATURE_DATE { get; set; }
        public decimal COMM_PRCNT { get; set; }
        public bool? STORE_CAN_RECEIVE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
    }
}
