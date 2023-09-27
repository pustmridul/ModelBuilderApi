using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("InvTrackingSummaryTemp")]
    public class InvTrackingSummaryTemp
    {
        public string? InvtrackNo { get; set; }
        public string? Barcode { get; set; }
        public string? sBarcode { get; set; }
        public DateTime? ExpDT { get; set; }
        public decimal StartQty { get; set; }
        public decimal StartSaleQty { get; set; }
        public decimal ScanQty { get; set; }
        public decimal PresentSaleQty { get; set; }
        public decimal AdjQty { get; set; }
        public string? SessionId { get; set; }
        public DateTime? ScanStartDate { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? CreatedBy { get; set; }
        public decimal MRP { get; set; }
        public string? Description { get; set; }
        public string? COO { get; set; }
        public decimal CPU { get; set; }
        public DateTime? ScanEndDate { get; set; }
        public string? PostedBy { get; set; }
        public bool IsAdj { get; set; }
        public string? Product { get; set; }
        public string Transfer { get; set; }
        public string? CounterID { get; set; }
        public string? User_Barcode { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int ID { get; set; }
    }
}
