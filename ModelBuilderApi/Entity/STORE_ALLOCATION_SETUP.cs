using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_ALLOCATION_SETUP")]
    public class STORE_ALLOCATION_SETUP
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        public string? ALLOCATION_ATTRIBUTE_CODE { get; set; }
        public string? DISTRIBUTION_ATTRIBUTE_CODE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
