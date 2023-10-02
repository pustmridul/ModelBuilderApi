using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE_BRAND")]
    public class STORE_BRAND
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]

        public string STORE_CODE { get; set; }
        [Key]
        public string BRAND_CODE { get; set; }

    }
}
