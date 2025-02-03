using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class WorkOrderGL
    {
        public string WONO { get; set; }
        public string? CompanyId { get; set; }
        public DateTime? WODate { get; set; }
        public DateTime? DeliveryDT { get; set; }
        public string? SupID { get; set; }
        public string? SupName { get; set; }
        public string? SupAddress { get; set; }
        public string? CostCenterID { get; set; }
        public string MeterialID { get; set; }
        public string? Name { get; set; }
        public string? Specification { get; set; }
        public decimal? CPU { get; set; }
        public decimal? OrderQty { get; set; }
        public decimal? ReceivingQty { get; set; }
        public decimal? ItemTotalAmt { get; set; }
        public string? Remarks { get; set; }
        public string? Status { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string? DeliveryTerms { get; set; }
        public string? PaymentTerms { get; set; }
    }
}
