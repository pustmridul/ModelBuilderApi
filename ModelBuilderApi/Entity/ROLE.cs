using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ROLE")]
    public class ROLE
    {
        [Key]
        public string ROLE_NAME { get; set; }
        public string? DESCRIPTION { get; set; }
    }
}
