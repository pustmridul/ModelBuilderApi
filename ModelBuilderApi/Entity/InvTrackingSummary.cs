using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class InvTrackingSummary
    {
        public string? company_code { get; set; }
        public string? store_code { get; set; }
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
        public decimal? AdjCPU { get; set; }
        public bool NonSalableItemStkAdj { get; set; }
        public bool IsDiscard { get; set; }
        public DateTime? DiscardDate { get; set; }
        public string? user_barcode { get; set; }
        public string Transfer { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? RCV_NO { get; set; }
        public DateTime? RCV_DATE { get; set; }
        public string NOTES { get; set; }
        public string INV_TYPE { get; set; }
        public string Reference { get; set; }
    }
}
