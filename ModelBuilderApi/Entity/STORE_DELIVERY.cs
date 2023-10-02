using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_DELIVERY")]
    public class STORE_DELIVERY
    {
        public string CHALLAN_NO { get; set; }
        public DateTime DELIVERY_DATE { get; set; }
        public string STORE_CODE { get; set; }
        public string DELIVERY_TO { get; set; }
        public string COMPANY_CODE { get; set; }
        public string? REF_NO { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string STATUS { get; set; }
        public DateTime? RECEIVE_DATE { get; set; }
        public string? VEHICLE_NO { get; set; }
        public string DEL_TYPE { get; set; }
        public string? SystemRef { get; set; }
        public string? RECEIVED_BY { get; set; }
        public DateTime? RECEIVED_DATE { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string? REMARKS { get; set; }
        public string? UUID { get; set; }
        public string? APPROVAL_EMAIL_STATUS { get; set; }
        public string? DELIVERY_MAN { get; set; }
        public string NOTE { get; set; }
        public string SUMMARY_NO { get; set; }
    }
}
