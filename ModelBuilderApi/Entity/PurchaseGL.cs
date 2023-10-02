using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PurchaseGL")]
    public class PurchaseGL
    {
        public decimal ID { get; set; }
        public string ChlnNo { get; set; }
        public string? BillNo { get; set; }
        public string? PONO { get; set; }
        public string? MaterialId { get; set; }
        public string? MaterialName { get; set; }
        public string? Specification { get; set; }
        public string? UnitType { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? CPU { get; set; }
        public decimal? ACPU { get; set; }
        public decimal? ReceivingQty { get; set; }
        public decimal? QCPassedQty { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? Remarks { get; set; }
        public string? UserName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? actcode { get; set; }
        public string? actname { get; set; }
    }
}
