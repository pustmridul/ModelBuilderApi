using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PurchaseOrderGL")]
    public class PurchaseOrderGL
    {
        public string PONO { get; set; }
        public string? CompanyID { get; set; }
        public string? SupID { get; set; }
        public string? SupName { get; set; }
        public string? CostCenterID { get; set; }
        public string MeterialID { get; set; }
        public string? Name { get; set; }
        public string? Specification { get; set; }
        public string? UnitId { get; set; }
        public string? UnitType { get; set; }
        public decimal? RequisitionQty { get; set; }
        public decimal? CPU { get; set; }
        public decimal? OrderQty { get; set; }
        public decimal? ReceivingQty { get; set; }
        public decimal? IssueQty { get; set; }
        public decimal? ItemTotalAmt { get; set; }
        public string? Instruction { get; set; }
        public string? Remarks { get; set; }
        public string? Status { get; set; }
        public string? UserName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? SupAddress { get; set; }
        public string? DeliveryTo { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? BillTo { get; set; }
        public string? BillToAddress { get; set; }
        public DateTime? DeliveryDT { get; set; }
        public DateTime? PODate { get; set; }
        public string? ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
    }
}
