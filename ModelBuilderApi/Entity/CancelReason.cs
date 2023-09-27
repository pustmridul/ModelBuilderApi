using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CancelReason")]
    public class CancelReason
    {
        public int ReasonID { get; set; }
        public string? Description { get; set; }
    }
}
