using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRIORITY")]
    public class PRIORITY
    {
        public string CODE { get; set; }
        [Key]
        public string PRIORITY_NAME { get; set; }
        public string PRIORITY_TYPE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
