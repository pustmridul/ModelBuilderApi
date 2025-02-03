using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class InvTrackingDetails
    {
        public string? Barcode { get; set; }
        public string? sBarcode { get; set; }
        public DateTime? ExpDT { get; set; }
        public decimal ScanQty { get; set; }
        public string? CounterID { get; set; }
        public string? UserId { get; set; }
        public string? SessionId { get; set; }
        public DateTime? ScanStartDate { get; set; }
        public DateTime? ScanEndDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Description { get; set; }
        public string? COO { get; set; }
        public decimal MRP { get; set; }
        public string? SL { get; set; }
        public string? User_Barcode { get; set; }
        public string? InvtrackNo { get; set; }
    }
}
