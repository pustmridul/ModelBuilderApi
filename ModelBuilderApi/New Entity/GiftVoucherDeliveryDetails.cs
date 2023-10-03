namespace ModelBuilderApi.New_Entity
{
    public class GiftVoucherDeliveryDetails
    {
        public string? ChallanNo { get; set; }
        public string? STORE_CODE { get; set; }
        public string? DELIVERY_TO { get; set; }
        public string? CARD_TYPE { get; set; }
        public decimal? Amount { get; set; }
        public long? Quantity { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? RcvdBy { get; set; }
        public string CUSTOMER_ID { get; set; }
        public long? SerialStart { get; set; }
        public long? SerialEnd { get; set; }
        public string? COMPANY_CODE { get; set; }
        public decimal? RCV_QTY { get; set; }
        public string? VOUCHER_NO { get; set; }
        public DateTime? RcvdDt { get; set; }
        public DateTime? ChallanDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
