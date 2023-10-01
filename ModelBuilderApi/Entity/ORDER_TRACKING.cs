using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ORDER_TRACKING")]
    public class ORDER_TRACKING
    {
        [Key]
        public int ID { get; set; }
        public string? BROWSER_IP { get; set; }
        public string? ACCEPT_LANGUAGE { get; set; }
        public string? SESSION_HASH { get; set; }
        public string? BROWSER_WIDTH { get; set; }
        public string? BROWSER_HEIGHT { get; set; }
        public string? ORDER_ID { get; set; }
    }
}
