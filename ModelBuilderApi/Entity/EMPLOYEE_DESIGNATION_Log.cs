using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("EMPLOYEE_DESIGNATION_Log")]
    public class EMPLOYEE_DESIGNATION_Log
    {
        public string DESIGNATION_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string COMPANY_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
