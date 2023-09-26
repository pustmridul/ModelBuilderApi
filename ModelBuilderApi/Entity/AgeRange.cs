using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("AgeRange")]
    public class AgeRange
    {
        [Key]
        public string RANGE { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
    }
}
