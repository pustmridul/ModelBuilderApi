using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CITY")]
    public class CITY
    {
        public string CODE { get; set; }
        [Key]
        public string CITY_NAME { get; set; }
    }
}
