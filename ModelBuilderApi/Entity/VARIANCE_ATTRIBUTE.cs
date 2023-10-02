using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("VARIANCE_ATTRIBUTE")]
    public class VARIANCE_ATTRIBUTE
    {
        public string CODE { get; set; }
        [Key]
        public string ATTRIBUTE_NAME { get; set; }
        [Key]
        public string VARIANCE_CODE { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }

        public int? SERIAL { get; set; }
        public int VALUE_SERIAL { get; set; }
    }
}
