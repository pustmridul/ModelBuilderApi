using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("MEASURING_UNIT_Log")]
    public class MEASURING_UNIT_Log
    {
        public decimal SERIAL { get; set; }
        public string DESCRIPTION { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
