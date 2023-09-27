using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ConsoleType")]
    public class ConsoleType
    {
        public int TypeId { get; set; }
        public string ConsolesType { get; set; }
    }
}
