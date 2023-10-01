using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("OrderNote")]
    public class OrderNote
    {
        [Key]
        public int Id { get; set; }
        public string? ORDER_ID { get; set; }
        public DateTime? CREATED_AT { get; set; }
        public string? CUSTOMER_ID { get; set; }
        public string? CREATED_BY { get; set; }
        public string? NOTE { get; set; }
        public string? NoteType { get; set; }
    }
}
