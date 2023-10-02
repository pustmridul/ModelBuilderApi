using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("USERS")]
    public class USERS
    {
        [Key]
        public string USERNAME { get; set; }
        public string ROLE_NAME { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string? PASSWORD { get; set; }
        public string? HashKey { get; set; }
    }
}
