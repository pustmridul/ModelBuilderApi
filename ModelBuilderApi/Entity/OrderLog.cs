using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class OrderLog
    {
        
        public long Id { get; set; }
        public string OrderId { get; set; }
        public string? OrderStatus { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangedDate { get; set; }
        public string? Remarks { get; set; }
        public string? Note { get; set; }
    }
}
