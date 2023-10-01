using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("MEASURING_UNIT")]
    public class MEASURING_UNIT
    {
        [Key]
        public decimal SERIAL { get; set; }
        [Key]
        public string DESCRIPTION { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
