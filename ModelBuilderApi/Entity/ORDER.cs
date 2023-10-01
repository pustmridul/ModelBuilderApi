using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ORDER")]
    public class ORDER
    {
        [Key]
        public int Id { get; set; }
        public string? ORDER_ID { get; set; }
        public DateTime? CREATED_AT { get; set; }
        public decimal? TOTAL_PRICE { get; set; }
        public decimal? SUB_TOTAL_PRICE { get; set; }
        public decimal? TOTAL_TAX { get; set; }
        public string? TAX_INCLUDED { get; set; }
        public string? CURRENCY { get; set; }
        public string? PHONE { get; set; }
        public string? ORDER_NUMBER { get; set; }
        public string? CUSTOMER_ID { get; set; }
        public decimal? DISC_PRCNT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public string? CREATED_BY { get; set; }
        public string? ORDER_FROM { get; set; }
        public string? ORDER_STATUS { get; set; }
        public string? DELIVERY_TYPE { get; set; }
        public string? DELIVERY_PERSON_ID { get; set; }
        public string? COURIER_SERVICE_ID { get; set; }
        public string? CHALLAN_NO { get; set; }
        public decimal? SERVICE_CHARGE { get; set; }
        public decimal? NET_AMT { get; set; }
        public int? REASON_ID { get; set; }
        public string? CANCEL_REASON { get; set; }
        public string? CANCEL_BY { get; set; }
        public DateTime? ACC_DEL_DATE { get; set; }
        public string? CONFIRM_BY { get; set; }
        public string? PAYMENT_TYPE { get; set; }
        public string? REQ_NO { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? NOTE { get; set; }
        public DateTime? ADEL_DATE { get; set; }
        public string? PAYMENT_STATUS { get; set; }
        public string ShopifyCanceledSync { get; set; }
        public string? SHIPPING_METHOD { get; set; }
        public string? EcCompletSync { get; set; }
        public string? EcShipSync { get; set; }
        public string? CUSTOMER_FEEDBACK { get; set; }
        public string? DELIVERY_POINT { get; set; }
        public string? ORDER_NOTE { get; set; }
        public string? TRANSFER { get; set; }
        public string? ADDRESS_TYPE { get; set; }
        public decimal? ADDRESS_TYPE_CHARGE { get; set; }
        public bool? IS_STATUS_SYNC { get; set; }
        public string? PRD_SKU { get; set; }
        public string? PRD_BARCODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? PICK_STORE_CODE { get; set; }
        public bool? IS_STORE_TRANSFER { get; set; }
        public string? CustomerLatitude { get; set; }
        public string? CustomerLongitude { get; set; }
        public string? ShopLatitude { get; set; }
        public string? ShopLongitude { get; set; }
        public decimal? EarndPoint { get; set; }
        public decimal? RedeemPoint { get; set; }
        public string? SSLCommerceTransaction { get; set; }
        public bool IsProcessing { get; set; }
        public string? ProcessingBy { get; set; }
        public decimal PartialAmount { get; set; }
        public long CourierLocationId { get; set; }
        public string? MargeOrderNo { get; set; }
        public string? IssueType { get; set; }
        public string? IssueText { get; set; }
        public string? IssueStatus { get; set; }
        public string? OrderLastStatus { get; set; }
        public string? TrxID { get; set; }
        public string? CourierType { get; set; }
        public string? AdvPayMode { get; set; }
    }
}
