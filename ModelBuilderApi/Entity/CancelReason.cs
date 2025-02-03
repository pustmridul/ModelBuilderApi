using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CancelReason
    {
        public int ReasonID { get; set; }
        public string? Description { get; set; }
    }
}
