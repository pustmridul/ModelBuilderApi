using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("BRAND")]
    public class BRAND
    {

        public string CODE { get; set; }
        [Key]
        public string BRAND_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string IMAGE_URL { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
