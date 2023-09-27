using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("GIFT_VOUCHER_GENERATION_LOG")]
    public class GIFT_VOUCHER_GENERATION_LOG
    {
        public string? VOUCHER_NO { get; set; }
        public string? CARD_TYPE { get; set; }
        public bool? IS_SOLD { get; set; }
        public DateTime? SOLD_DATE { get; set; }
        public string? SOLD_INVOICE { get; set; }
        public string? SOLD_STORE { get; set; }
        public bool? IS_SCANNED { get; set; }
        public DateTime? SCAN_DATE { get; set; }
        public string? SCAN_INVOICE { get; set; }
        public string? SCAN_STORE { get; set; }
        public decimal? VOUCHER_AMOUNT { get; set; }
        public decimal? SCAN_AMOUNT { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string? UPDATE_BY { get; set; }
        public string? COMPANY_CODE { get; set; }
        public bool? IS_AUTO_ACTIVE { get; set; }
        public decimal SAL_DISC_AMT { get; set; }
        public string? SESSION_ID { get; set; }
        public DateTime? SESSION_TIME { get; set; }
        public string DELIVERY_STATUS { get; set; }
        public string? RECEIVE_STORE { get; set; }
        public DateTime? VALID_TO { get; set; }
    }
}
